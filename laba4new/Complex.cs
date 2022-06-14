using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4new
{
    internal class Complex
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Complex(double a, double b)
        {
            X = a;
            Y = b;
        }
        public Complex Add(Complex B)
        {
            return new Complex(this.X+this.Y,B.X+B.Y);
        }
        public Complex Sub(Complex B)
        {
            return new Complex(this.X - this.Y, B.X - B.Y);
        }
        public Complex Multi(Complex B)
        {
            return new Complex(this.X * B.X-this.Y*B.Y, this.X*B.X + B.Y);
        }
        public double Divis()
        {
            return A / B;
        }
        public double Equ()
        {
            return A = B;
        }
        public double conj()
        {
            return C=A-B*D;
        }
    }
}
