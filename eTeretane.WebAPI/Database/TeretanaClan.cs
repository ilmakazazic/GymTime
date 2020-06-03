using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class TeretanaClan
    {
        public int TeretanaClanId { get; set; }
        public DateTime DatumUclanjivanja { get; set; }

        public int TeretanaId { get; set; }
        public Teretana Teretana { get; set; }
        public int ClanId { get; set; }
        public Clan Clan { get; set; }
    }
}
