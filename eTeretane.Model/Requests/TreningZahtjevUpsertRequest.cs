namespace eTeretane.Model.Requests
{
    public class TreningZahtjevUpsertRequest
    {
        public int ClanId { get; set; }
        public int TreningId { get; set; }
        public bool Odobren { get; set; }
        public string DatumOdrzavanja { get; set; }
        public string PocetakTreninga { get; set; }
        public string KrajTreninga { get; set; }
    }
}
