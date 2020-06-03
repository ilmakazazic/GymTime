using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
