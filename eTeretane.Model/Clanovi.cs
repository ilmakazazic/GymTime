using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model
{
    public class Clanovi
    {
        public int ClanId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRegistracije { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public bool Status { get; set; }

        public int KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }


        public string ImePrezime
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }


    }
}
