using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class TreningDetalji
    {
        public int TreningDetaljiId { get; set; }
        public bool Otkazan { get; set; }


        public int TreningId { get; set; }
        public Trening Trening { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }

    }
}
