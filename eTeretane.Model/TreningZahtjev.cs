using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model
{
    public class TreningZahtjev
    {
        public int TreningZahtjevId { get; set; }

        public int ClanId { get; set; }
        public Clanovi Clan { get; set; }

        public int TreningId { get; set; }
        public Trening Trening { get; set; }

        public bool Odobren { get; set; }


    }
}
