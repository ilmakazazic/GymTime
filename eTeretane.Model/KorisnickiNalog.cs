using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model
{
    public  class KorisnickiNalog
    {
        public int KorisnickiNalogId { get; set; }
        public  string Username { get; set; }

        public ICollection<KorisniciUloge> KorisniciUloge { get; set; }

    }
}
