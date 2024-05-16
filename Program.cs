using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Es1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1=new Complex(1, 2);
            Complex c2=new Complex(3, 4);
            Console.WriteLine(c1+c2);
            double mod=c1.Module();
        }
    }
}
