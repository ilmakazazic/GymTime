using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class KorisniciUpsertRequest : KorisnickiNalogUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public DateTime DatumPolaganja { get; set; }
        public DateTime DatumIsteka { get; set; }


        public List<int> Licence { get; set; } = new List<int>();
    }
}
