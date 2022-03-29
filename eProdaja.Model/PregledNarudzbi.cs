using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model
{
    public class PregledNarudzbi
    {
        public int PregledNarudzbiId { get; set; }
        public  Kupci Kupac { get; set; }
        public int? KupacId { get; set; }
        public  Proizvodi Porizvod { get; set; }
        public int? ProizvodId { get; set; }
        public DateTime DatumOD { get; set; }
        public DateTime DatumDO { get; set; }
        public string BrojNarudzbe { get; set; }
        public decimal IznosNarudzbe { get; set; }
        public decimal MinimalniIznosNarudzbe { get; set; }
        public decimal ProsjecniPromet { get; set; }

    }
}
