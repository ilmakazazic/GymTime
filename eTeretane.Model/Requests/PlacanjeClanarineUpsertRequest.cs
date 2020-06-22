using System;
using System.Collections.Generic;
using System.Text;

namespace eTeretane.Model.Requests
{
    public class PlacanjeClanarineUpsertRequest : ClanarinaUpsertRequest
    {
        public string BrojKartice { get; set; }
        public int SecurityCode { get; set; }
        public int ExpMonth { get; set; }
        public int ExpYear { get; set; }

        //public int ClanarinaId { get; set; }
        //public Clanarina Clanarina { get; set; }

    }
}
