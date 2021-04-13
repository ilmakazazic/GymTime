namespace eTeretane.WebAPI.Database
{
    public class TreningZahtjev
    {
        public int TreningZahtjevId { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
        public int TreningId { get; set; }
        public Trening Trening { get; set; }
        public bool Odobren { get; set; }
    }
}
