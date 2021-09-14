using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Teglalap : Sokszog
    {
        public double oldalB { get; set; }
        public Teglalap(double A, double B) : base(A)
        {
            oldalB = B;
        }

        public override double Kerulet()
        {
            return (2 * oldalA) + (2 * oldalB);
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
