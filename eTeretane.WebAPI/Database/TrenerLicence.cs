using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class TrenerLicence
    {
        public int TrenerLicenceId { get; set; }
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }
        public int LicencaId { get; set; }
        public Licenca Licenca { get; set; }

    }
}
