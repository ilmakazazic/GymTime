using System;

namespace eTeretane.Model
{
    public class TreningZahtjev
    {
        public int TreningZahtjevId { get; set; }
        public int ClanId { get; set; }
        public virtual Clanovi Clan { get; set; }
        public int TreningId { get; set; }
        public virtual Trening Trening { get; set; }
        public bool Odobren { get; set; }
        public string ClanIme { get; set; }
        public DateTime TreningDatum { get; set; }
        public DateTime TreningPocetak { get; set; }
        public DateTime TreningKraj { get; set; }
        public int TrenutnoRezervacija { get; set; }
        public int TeretanaId { get; set; }
        public string TeretanaIme { get; set; }
    }
}
