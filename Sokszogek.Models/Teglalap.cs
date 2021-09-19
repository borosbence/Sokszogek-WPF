using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Teglalap : Sokszog
    {
        public double OldalB { get; set; }
        public Teglalap(double A, double B) : base(A)
        {
            OldalB = B;
        }

        public override double Kerulet()
        {
            if (OldalA <= 0 || OldalB <= 0)
            {
                return double.NaN;
            }
            return (2 * OldalA) + (2 * OldalB);
        }

        public override double Terulet()
        {
            if (OldalA <= 0 || OldalB <= 0)
            {
                return double.NaN;
            }
            return OldalA * OldalB;
        }
    }
}
