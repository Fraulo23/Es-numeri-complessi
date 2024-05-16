using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Es1
{
    internal class Complex
    {
        private readonly double A;
        private readonly double B;
       
        public double a { get { return A; } }
        public double b { get { return B; } }
        
        public Complex(double a, double b)
        {
            this.A = a;
            this.B = b;
        }
        public Complex(double module, int angle)
        {
            A = module * Math.Cos(angle / 180.0 * Math.PI);
            B = module * Math.Sin(angle / 180.0 * Math.PI);
        }

        public static Complex ParseN(string s)
        {
            char[] segni = { '+', '-' };
            string[] parts = s.Split(segni);
            float a = float.Parse(parts[0]);
            int index = parts[1].IndexOf("i");
            float b = float.Parse(parts[1].Substring(index+1));
            
            return new Complex(a, b);
        }
        public static Complex ParseMA(string s)
        {
            string[] parts = s.Split('<');
            float mod = float.Parse(parts[0]);
            float ang = float.Parse(parts[1]);
            return new Complex(mod, ang);
        }
        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.a+c2.a, c1.b+c2.b);
        }
        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.a - c2.a, c1.b - c2.b);
        }
        public static Complex operator *(Complex a, double b)
        {
            return new Complex(a.a *b,a.b *b);
        }
        public static Complex operator *(Complex c1,Complex c2)
        {

            return new Complex(c1.Module()*c2.Module(),(c1.Angle()+c2.Angle())/360);
        }
        public double Module()
        {
            return (Math.Sqrt(a * a + b * b));
        }
        public double Angle()
        {
            return (Math.Atan(b / a));
        }
        public override string ToString()
        {
            return A + "+i" + B;
        }
    }
}
