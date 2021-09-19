using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Negyzet : Sokszog
    {
        public Negyzet(double A) : base(A)
        {

        }

        public override double Kerulet()
        {
            if (OldalA <= 0)
            {
                return double.NaN;
            }
            return 4 * OldalA;
        }

        public override double Terulet()
        {
            if (OldalA <= 0)
            {
                return double.NaN;
            }
            return Math.Pow(OldalA, 2);
        }
    }
}
