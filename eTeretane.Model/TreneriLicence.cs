using System;

namespace eTeretane.Model
{
    public class TreneriLicence
    {
        public int TrenerLicenceId { get; set; }
        public DateTime DatumPolaganja { get; set; }
        public DateTime DatumIsteka { get; set; }
        public int KorisnikId { get; set; }
        public Korisnici Korisnik { get; set; }
        public int LicencaId { get; set; }
        public Licenca Licenca { get; set; }
    }
}
