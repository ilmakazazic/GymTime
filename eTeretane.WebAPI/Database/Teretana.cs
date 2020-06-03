using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class Teretana
    {
        public int TeretanaId { get; set; }
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public DateTime PocetakRadnoVrijeme { get; set; }
        public DateTime KrajRadnoVrijeme { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int GradId { get; set; }
        public Grad Grad { get; set; }


    }
}
