using System;

namespace eTeretane.WebAPI.Database
{
    public class Poruke
    {
        public int PorukeId { get; set; }
        public string Poruka { get; set; }
        public DateTime DatumVrijeme { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int  ClanId { get; set; }
        public Clan Clan { get; set; }
    }
}
