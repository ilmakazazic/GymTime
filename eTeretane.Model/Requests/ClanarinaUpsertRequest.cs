using System;

namespace eTeretane.Model.Requests
{
    public class ClanarinaUpsertRequest
    {
        public DateTime DatumUplate { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int TipClanarineId { get; set; }
        public TipClanarine TipClanarine { get; set; }
        public int ClanId { get; set; }
        public Clanovi Clan { get; set; }
        public int TeretanaId { get; set; }
        public Teretane Teretana { get; set; }
    }
}
