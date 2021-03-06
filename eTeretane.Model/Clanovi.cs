﻿using System;

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
        public int KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
        public int GradId { get; set; }

        public string ImePrezime => Ime + " " + Prezime;

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }


}

