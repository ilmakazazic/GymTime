namespace eTeretane.Model
{
    public class Grad
    {
        public int GradId { get; set; }
        public string Naziv { get; set; }
        public int PPT { get; set; }
        public int DrzavaId { get; set; }
        public Drzave Drzava { get; set; }
    }
}
