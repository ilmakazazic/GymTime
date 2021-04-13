namespace eTeretane.Model.Requests
{
    public class PlacanjeClanarineUpsertRequest : ClanarinaUpsertRequest
    {
        public string BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }
    }
}
