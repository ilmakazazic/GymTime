namespace eTeretane.Model.Requests
{
    public class ClanUpsertRequest : KorisnickiNalogUpsertRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public int GradId { get; set; }
    }
}
    