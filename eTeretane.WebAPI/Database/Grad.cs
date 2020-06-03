using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTeretane.WebAPI.Database
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int PPT { get; set; }

        public int DrzavaId { get; set; }
        public Drzava Drzava { get; set; }

    }
}
