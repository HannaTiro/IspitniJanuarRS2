using System;
using System.Collections.Generic;
using System.Text;

namespace eProdaja.Model.Requests
{
    public class NarudzbeSearchRequest
    {
        public int? ProizvodId { get; set; }
       
        public DateTime? DatumOD { get; set; }
        public DateTime? DatumDO{ get; set; }

        public decimal? MinimalniIznosNarudzbe { get; set; }
    }
}
