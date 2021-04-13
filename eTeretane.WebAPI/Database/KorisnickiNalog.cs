namespace eTeretane.WebAPI.Database
{
    public class KorisnickiNalog
    {
        public int KorisnickiNalogId { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Username { get; set; }
    }
}
