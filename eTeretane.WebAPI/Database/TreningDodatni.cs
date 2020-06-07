using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class TreningDodatni
    {
        public int TreningDodatniId { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public DateTime PocetakTreninga { get; set; }
        public DateTime KrajTreninga { get; set; }
        public bool Prihvacen { get; set; }

        public int TeretanaId { get; set; }
        public Teretana Teretana { get; set; }

        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        public int ClanId { get; set; }
        public Clan Clan { get; set; }
    }
}
