using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace eTeretane.Model.Requests
{
    public class TeretanaSearchRequest
    {
        public string Naziv { get; set; }
        public int GradId { get; set; }
    }
}
