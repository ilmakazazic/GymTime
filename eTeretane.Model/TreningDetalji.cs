using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model
{
    public class TreningDetalji
    {
        public int TreningDetaljiId { get; set; }
        public bool Otkazan { get; set; }


        public int TreningId { get; set; }
        public Trening Trening { get; set; }
        public int ClanId { get; set; }
        public Clanovi Clan { get; set; }

    }
}
