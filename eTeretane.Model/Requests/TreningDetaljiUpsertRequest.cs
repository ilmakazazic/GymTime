using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class TreningDetaljiUpsertRequest
    {
        public bool Otkazan { get; set; }

        public int TreningId { get; set; }
        public int ClanId { get; set; }

    }
}
