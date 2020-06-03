using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class TerminiUpsertRequest
    {
        public DateTime DatumOdrzavanja { get; set; }
        public DateTime PocetakTreninga { get; set; }
        public DateTime KrajTreninga { get; set; }
        public int BrojRezervacija { get; set; }

        public int TeretanaId { get; set; }
        public int KorisnikId { get; set; }

    }
}
