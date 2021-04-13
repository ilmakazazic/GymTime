using System;

namespace eTeretane.Model
{
    public class KorisniciUloge
    {
        public int KorisniciUlogeId { get; set; }
        public DateTime DatumIzmjene { get; set; }
        public int KorisnickiNalogId { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
        public int UlogaId { get; set; }
        public Uloge Uloga { get; set; }
    }
}
