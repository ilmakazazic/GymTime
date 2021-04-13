using System;

namespace eTeretane.WebAPI.Database
{
    public class KorisniciUloge
    {
        public int KorisniciUlogeId { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public int KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
        public int UlogaId { get; set; }
        public Uloga Uloga { get; set; }
    }
}
