using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4new
{
    internal class Rational
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public Rational(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }
        public double Add()
        {
            return (A + B)/(C+D);
        }
        public double Sub()
        {
            return (A - B)/(C-D);
        }
        public double Multi()
        {
            return (A * B)/(C * D);
        }
        public double Divis()
        {
            return (A / B)/(C / D);
        }
        public double Equ()
        {
            return (A=B)/(C=D);
        }

    }
}
