using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public abstract class Sokszog
    {
        public double oldalA { get; set; }
        public abstract double Kerulet();
        public abstract double Terulet();
        public Sokszog(double A)
        {
            oldalA = A;
        }
    }
}
