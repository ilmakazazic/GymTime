namespace eTeretane.Model
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
        public string TipClanarineString { get; set; }
        public string ClanString { get; set; }
        public string TeretanaString { get; set; }
        public double cijenaString { get; set; }
        public string DatumUplate { get; set; }
        public string DatumIsteka { get; set; }

    }
}
