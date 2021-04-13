using System;

namespace eTeretane.Model
{
    public class TreningDodatni
    {
        public int TreningDodatniId { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public DateTime PocetakTreninga { get; set; }
        public DateTime KrajTreninga { get; set; }
        public bool Prihvacen { get; set; }
        public int TeretanaId { get; set; }
        public Teretane Teretana { get; set; }
        public int KorisnikId { get; set; }
        public Korisnici Korisnik { get; set; }
        public int ClanId { get; set; }
        public Clanovi Clan { get; set; }
        public string TeretanaNaziv { get; set; }
        public string KorisnikIme { get; set; }
        public string ClanIme { get; set; }
    }
}
