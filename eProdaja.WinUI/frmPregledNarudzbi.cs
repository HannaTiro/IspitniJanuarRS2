using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eProdaja.WinUI
{
    public partial class frmPregledNarudzbi : Form
    {
        APIService _serviceProizvodi = new APIService("Proizvodi");
        APIService _serviceNarudzbe = new APIService("Narudzbe");
        APIService _servicePregledNarudzbi = new APIService("PregledNarudzbi");


        public frmPregledNarudzbi()
        {
            InitializeComponent();
            dgvPodaci.AutoGenerateColumns = false;
        }

        private async void frmPregledNarudzbi_Load(object sender, EventArgs e)
        {
            await LoadProizvode();
            await LoadNarudzbe();
            
        }

        private async Task LoadNarudzbe()
        {
            var request = new Model.Requests.NarudzbeSearchRequest
            {
                DatumDO = dtpDO.Value,
                DatumOD = dtpOD.Value,
                MinimalniIznosNarudzbe = int.Parse(txtIznos.Text),
                ProizvodId = int.Parse(cmbProizvod.SelectedValue.ToString())
            };
            var podaci = await _serviceNarudzbe.GetAll<List<Model.Narudzbe>>(request);
            dgvPodaci.DataSource = podaci;
            lblIznos.Text = $"Suma: {podaci.Sum(x => x.UkupanIznos).ToString("0.00")} KM";
        }

        private async  Task LoadProizvode()
        {
            var request = await _serviceProizvodi.GetAll<List<Model.Proizvodi>>(null);
            cmbProizvod.DataSource = request;
            cmbProizvod.DisplayMember = "Naziv";
            cmbProizvod.ValueMember = "ProizvodId";

        }

        private async void btnPretrazi_Click(object sender, EventArgs e)
        {
            await LoadNarudzbe();
        }

        private async void btnSpasi_Click(object sender, EventArgs e)
        {
            await UnesiPodatke();
        }

        private async Task UnesiPodatke()
        {
            var podaci = dgvPodaci.DataSource as List<Model.Narudzbe>;
            foreach (var item in podaci)
            {
                var request = new Model.Requests.PregledNarudzbiInsertRequest
                {
                    BrojNarudzbe = item.BrojNarudzbe,
                    DatumDO = dtpDO.Value,
                    DatumOD = dtpOD.Value,
                    IznosNarudzbe = item.UkupanIznos,
                    KupacId = item.KupacId,
                    MinimalniIznosNarudzbe = int.Parse(txtIznos.Text),
                    ProizvodId = int.Parse(cmbProizvod.SelectedValue.ToString())
                };
                await _servicePregledNarudzbi.Insert<Model.PregledNarudzbi>(request);
            }
            MessageBox.Show("Uspješno dodano");
        }
    }
}
