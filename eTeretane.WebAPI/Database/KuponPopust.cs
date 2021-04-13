using System;

namespace eTeretane.WebAPI.Database
{
    public class KuponPopust
    {
        public int KuponPopustId { get; set; }
        public string KuponKod { get; set; }
        public int Postotak { get; set; }
        public DateTime PocetakDatum { get; set; }
        public DateTime KrajDatum { get; set; }
        public int Broj_Koristenja { get; set; }
        public bool Aktivan { get; set; }
        public int TeretanaId { get; set; }
        public Teretana Teretana { get; set; }
    }
}
