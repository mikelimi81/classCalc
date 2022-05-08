using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classCalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            int a = 1;
            int b = 2;
            
            Console.WriteLine(a + " + " + b + " = " + calc.Suma(a,b));
            Console.WriteLine(a + " - " + b + " = " + calc.Resta(a,b));
            Console.WriteLine(a + " * " + b + " = " + calc.Mult(a,b));
            Console.WriteLine(a + " / " + b + " = " + calc.Div(a,b));

            Console.Read();
        }
    }
}
