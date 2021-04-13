namespace eTeretane.WebAPI.Database
{
    public class TreningDetalji
    {
        public int TreningDetaljiId { get; set; }
        public bool Otkazan { get; set; }
        public int TreningId { get; set; }
        public Trening Trening { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
    }
}
