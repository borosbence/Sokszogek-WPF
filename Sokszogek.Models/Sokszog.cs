namespace Sokszogek.Models
{
    public abstract class Sokszog
    {
        public double OldalA { get; set; }
        public abstract double Kerulet();
        public abstract double Terulet();

        protected Sokszog(double A)
        {
            OldalA = A;
        }
    }
}
