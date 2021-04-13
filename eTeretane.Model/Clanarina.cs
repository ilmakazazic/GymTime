using System;

namespace eTeretane.Model
{
    public class Clanarina
    {
        public int ClanarinaId { get; set; }
        public DateTime DatumUplate { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int TipClanarineId { get; set; }
        public TipClanarine TipClanarine { get; set; }
        public int ClanId { get; set; }
        public Clanovi Clan { get; set; }
        public int TeretanaId { get; set; }
        public Teretane Teretana { get; set; }
        public string TipClanarineString { get; set; }
        public string ClanString { get; set; }
        public string TeretanaString { get; set; }
        public double cijenaString { get; set; }
    }
}
