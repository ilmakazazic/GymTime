using System;
using System.Collections.Generic;
using System.Text;

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

   
        public string ImePrezime
        {
            get
            {
                return Ime + " " + Prezime;
            }
        }


        public string Licence { get; set; }


        //public string Licenca_ispis
        //{
        //    get
        //    {
        //        string licence ="";

        //            foreach (var l in TreneriLicence)
        //            {
        //                licence = licence + l.Licenca.Tip + " ";
        //            }

        //            return licence;

        //    }
        //}

    }
}
