using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
   public  class PregledNarudzbiInsertRequest
    {
        public int KupacId { get; set; }
        public int ProizvodId { get; set; }
        public DateTime DatumOD { get; set; }
        public DateTime DatumDO { get; set; }
        public decimal MinimalniIznosNarudzbe { get; set; }
        public string BrojNarudzbe { get; set; }
        public decimal IznosNarudzbe { get; set; }

    }
}
