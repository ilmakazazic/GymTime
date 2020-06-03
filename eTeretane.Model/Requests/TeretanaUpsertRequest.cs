using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace eTeretane.Model.Requests
{
    public class TeretanaUpsertRequest
    {
        public string Naziv { get; set; }
        public string Adresa { get; set; }
        public DateTime PocetakRadnoVrijeme { get; set; }
        public DateTime KrajRadnoVrijeme { get; set; }
        public byte[] Slika { get; set; }
        public byte[] SlikaThumb { get; set; }
        public int GradId { get; set; }

    }
}
