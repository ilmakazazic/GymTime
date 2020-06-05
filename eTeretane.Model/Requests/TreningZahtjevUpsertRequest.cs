using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class TreningZahtjevUpsertRequest
    {
        public int ClanId { get; set; }
        public int TreningId { get; set; }

        public bool Odobren { get; set; }

    }
}
