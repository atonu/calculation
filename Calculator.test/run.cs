using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.lib;

namespace Calculator.test
{
    class run
    {
        static int Main(string[] args)
        {
            basicCalculator a = new basicCalculator();

            Console.WriteLine("Addition");
            Console.WriteLine(a.add(3, 5));
            Console.WriteLine("Substraction");
            Console.WriteLine(a.substract(3, 5));
            Console.WriteLine("Multiplication");
            Console.WriteLine(a.multiply(3, 5));
            Console.WriteLine("Division");
            Console.WriteLine(a.divide(10, 5));

            return 0;
        }
    }
}
