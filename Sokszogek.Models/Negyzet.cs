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
            if (oldalA <= 0)
            {
                return double.NaN;
            }
            return 4 * oldalA;
        }

        public override double Terulet()
        {
            if (oldalA <= 0)
            {
                return double.NaN;
            }
            return Math.Pow(oldalA, 2);
        }
    }
}
