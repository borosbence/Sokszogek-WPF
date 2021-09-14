﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Haromszog : Teglalap
    {
        public double oldalC { get; set; }

        public Haromszog(double A, double B, double C) : base(A, B)
        {
            oldalC = C;
        }

        public override double Kerulet()
        {
            if (oldalA <= 0 || oldalB <= 0 || oldalC <= 0)
            {
                return double.NaN;
            }
            return oldalA + oldalB + oldalC;
        }

        public override double Terulet()
        {
            if (oldalA <= 0 || oldalB <= 0 || oldalC <= 0)
            {
                return double.NaN;
            }
            
            // Hérón képlet
            double s = (oldalA + oldalB + oldalC) / 2;
            double terulet = Math.Sqrt(s *
                                (s - oldalA) *
                                (s - oldalB) *
                                (s - oldalC));
            return terulet;
        }
    }
}
