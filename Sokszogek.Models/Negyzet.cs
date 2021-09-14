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
            return 4 * oldalA;
        }

        public override double Terulet()
        {
            return Math.Pow(oldalA, 2);
        }
    }
}
