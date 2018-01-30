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


            Console.WriteLine(a.add(3, 5));
            Console.WriteLine(a.substract(3, 5));
            Console.WriteLine(a.multiply(3, 5));
            Console.WriteLine(a.divide(10, 5));

            return 0;
        }
    }
}
