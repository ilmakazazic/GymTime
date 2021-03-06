﻿using System.Collections.Generic;

namespace eTeretane.Model
{
    public class Korisnici
    {
        public int KorisnikId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string KorisnickoIme { get; set; }
        public int KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
        public ICollection<TreneriLicence> TreneriLicence { get; set; }
        public string ImePrezime => Ime + " " + Prezime;
        public string Licence { get; set; }
    }
}
