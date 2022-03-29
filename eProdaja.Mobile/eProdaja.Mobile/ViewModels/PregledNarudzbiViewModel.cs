using eProdaja.Mobile.Services;
using eProdaja.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Mobile.ViewModels
{
   public  class PregledNarudzbiViewModel:BaseViewModel
    {
        private readonly APIService _kupciService = new APIService("Kupci");
        private readonly APIService _pregledNarudzbiService = new APIService("PregledNarudzbi");

        Kupci _selectedKupac = null;
        public Kupci SelectedKupci 
        { 
            get { return _selectedKupac; } 
            set
            { 
                SetProperty(ref _selectedKupac, value); 
                    if (value != null) 
                    {
                     LoadPregledNarudzbi();
                    } 
            } 
        }

        private async void LoadPregledNarudzbi()
        {
            var request = new Model.Requests.PregledNarudzbiSearchRequest
            {
                KupacId = _selectedKupac.KupacId
            };
            var podaci = await _pregledNarudzbiService.Get<List<Model.PregledNarudzbi>>(request);
            PregledNarudzbiList.Clear();
            foreach (var item in podaci)
            {
                PregledNarudzbiList.Add(item);
            }
        }

        public ObservableCollection<Kupci> KupciList { get; set; } = new ObservableCollection<Kupci>();
        public ObservableCollection<PregledNarudzbi> PregledNarudzbiList { get; set; } = new ObservableCollection<PregledNarudzbi>();

        public async Task Init()
        {
            PregledNarudzbiList.Clear();
            var kupci = await _kupciService.Get<List<Model.Kupci>>();
            KupciList.Clear();
           foreach (var item in kupci)
            {
                KupciList.Add(item);
            }
        }

    }
}
