using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class KorisnickiNalogUpsertRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }

        public List<int> Uloge { get; set; } = new List<int>();

    }
}
