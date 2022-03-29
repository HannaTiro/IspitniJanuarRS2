
namespace eProdaja.WinUI
{
    partial class frmPregledNarudzbi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbProizvod = new System.Windows.Forms.ComboBox();
            this.dtpOD = new System.Windows.Forms.DateTimePicker();
            this.dtpDO = new System.Windows.Forms.DateTimePicker();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.btnSpasi = new System.Windows.Forms.Button();
            this.lblIznos = new System.Windows.Forms.Label();
            this.dgvPodaci = new System.Windows.Forms.DataGridView();
            this.Kupac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojNarudzbe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UkupanIznos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proizvod";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum od";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Datum do";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimalni iznos ";
            // 
            // cmbProizvod
            // 
            this.cmbProizvod.FormattingEnabled = true;
            this.cmbProizvod.Location = new System.Drawing.Point(16, 30);
            this.cmbProizvod.Name = "cmbProizvod";
            this.cmbProizvod.Size = new System.Drawing.Size(229, 21);
            this.cmbProizvod.TabIndex = 4;
            // 
            // dtpOD
            // 
            this.dtpOD.Location = new System.Drawing.Point(328, 31);
            this.dtpOD.Name = "dtpOD";
            this.dtpOD.Size = new System.Drawing.Size(230, 20);
            this.dtpOD.TabIndex = 5;
            // 
            // dtpDO
            // 
            this.dtpDO.Location = new System.Drawing.Point(328, 102);
            this.dtpDO.Name = "dtpDO";
            this.dtpDO.Size = new System.Drawing.Size(230, 20);
            this.dtpDO.TabIndex = 6;
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(15, 102);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(231, 20);
            this.txtIznos.TabIndex = 7;
            this.txtIznos.Text = "0";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(420, 160);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(138, 23);
            this.btnPretrazi.TabIndex = 9;
            this.btnPretrazi.Text = "Pretrazi";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // btnSpasi
            // 
            this.btnSpasi.Location = new System.Drawing.Point(420, 380);
            this.btnSpasi.Name = "btnSpasi";
            this.btnSpasi.Size = new System.Drawing.Size(138, 23);
            this.btnSpasi.TabIndex = 10;
            this.btnSpasi.Text = "Spasi";
            this.btnSpasi.UseVisualStyleBackColor = true;
            this.btnSpasi.Click += new System.EventHandler(this.btnSpasi_Click);
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Location = new System.Drawing.Point(12, 380);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(0, 13);
            this.lblIznos.TabIndex = 11;
            // 
            // dgvPodaci
            // 
            this.dgvPodaci.AllowUserToAddRows = false;
            this.dgvPodaci.AllowUserToDeleteRows = false;
            this.dgvPodaci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPodaci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kupac,
            this.BrojNarudzbe,
            this.Datum,
            this.UkupanIznos});
            this.dgvPodaci.Location = new System.Drawing.Point(12, 199);
            this.dgvPodaci.Name = "dgvPodaci";
            this.dgvPodaci.ReadOnly = true;
            this.dgvPodaci.Size = new System.Drawing.Size(546, 166);
            this.dgvPodaci.TabIndex = 8;
            // 
            // Kupac
            // 
            this.Kupac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Kupac.DataPropertyName = "Kupac";
            this.Kupac.HeaderText = "Ime i prezime";
            this.Kupac.Name = "Kupac";
            this.Kupac.ReadOnly = true;
            // 
            // BrojNarudzbe
            // 
            this.BrojNarudzbe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojNarudzbe.DataPropertyName = "BrojNarudzbe";
            this.BrojNarudzbe.HeaderText = "Broj narudzbe";
            this.BrojNarudzbe.Name = "BrojNarudzbe";
            this.BrojNarudzbe.ReadOnly = true;
            // 
            // Datum
            // 
            this.Datum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Datum.DataPropertyName = "Datum";
            this.Datum.HeaderText = "Datum";
            this.Datum.Name = "Datum";
            this.Datum.ReadOnly = true;
            // 
            // UkupanIznos
            // 
            this.UkupanIznos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UkupanIznos.DataPropertyName = "UkupanIznos";
            this.UkupanIznos.HeaderText = "Ukupan iznos";
            this.UkupanIznos.Name = "UkupanIznos";
            this.UkupanIznos.ReadOnly = true;
            // 
            // frmPregledNarudzbi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 433);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.btnSpasi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.dgvPodaci);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.dtpDO);
            this.Controls.Add(this.dtpOD);
            this.Controls.Add(this.cmbProizvod);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPregledNarudzbi";
            this.Text = "frmPregledNarudzbi";
            this.Load += new System.EventHandler(this.frmPregledNarudzbi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPodaci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbProizvod;
        private System.Windows.Forms.DateTimePicker dtpOD;
        private System.Windows.Forms.DateTimePicker dtpDO;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.Button btnSpasi;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.DataGridView dgvPodaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kupac;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojNarudzbe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn UkupanIznos;
    }
}