using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace eTeretane.Model
{
    public class Teretane
    {
        public int TeretanaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public DateTime PocetakRadnoVrijeme { get; set; }
        public DateTime KrajRadnoVrijeme { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int GradId { get; set; }

        public string Grad { get; set; }
    }
}
