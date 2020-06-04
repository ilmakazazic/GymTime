using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class KorisniciSearchRequest
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Username { get; set; }
    }
}
