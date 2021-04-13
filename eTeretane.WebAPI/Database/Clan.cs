using System;

namespace eTeretane.WebAPI.Database
{
    public class Clan
    {
        public int ClanId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public  string Telefon { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }
        public int KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
    }
}
