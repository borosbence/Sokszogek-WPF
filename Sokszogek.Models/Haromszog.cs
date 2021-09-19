using System;

namespace Sokszogek.Models
{
    public class Haromszog : Teglalap
    {
        public double OldalC { get; set; }

        public Haromszog(double A, double B, double C) : base(A, B)
        {
            OldalC = C;
        }

        public override double Kerulet()
        {
            if (OldalA <= 0 || OldalB <= 0 || OldalC <= 0)
            {
                return double.NaN;
            }
            return OldalA + OldalB + OldalC;
        }

        public override double Terulet()
        {
            if (OldalA <= 0 || OldalB <= 0 || OldalC <= 0)
            {
                return double.NaN;
            }

            // Hérón képlet
            double s = (OldalA + OldalB + OldalC) / 2;
            double terulet = Math.Sqrt(s *
                                (s - OldalA) *
                                (s - OldalB) *
                                (s - OldalC));
            return terulet;
        }
    }
}
