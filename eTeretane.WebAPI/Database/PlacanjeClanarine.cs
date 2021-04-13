namespace eTeretane.WebAPI.Database
{
    public class PlacanjeClanarine
    {
        public int PlacanjeClanarineID { get; set; }
        public string BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
        public int ClanarinaId { get; set; }
        public Clanarina Clanarina { get; set; }
    }
}
