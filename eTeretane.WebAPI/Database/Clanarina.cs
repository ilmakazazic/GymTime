using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class Clanarina
    {
        public int ClanarinaId { get; set; }

        public DateTime DatumUplate { get; set; }
        public DateTime DatumIsteka { get; set; }

        public int TipClanarineId { get; set; }
        public TipClanarine TipClanarine { get; set; }

        public int ClanId { get; set; }
        public Clan Clan { get; set; }

        public int TeretanaId { get; set; }
        public Teretana Teretana { get; set; }


    }
}
