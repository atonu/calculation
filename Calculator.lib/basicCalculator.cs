using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.lib
{
    public class basicCalculator
    {
        public int add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        public int substract(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public int multiply(int arg1, int arg2)
        {
            return arg1 * arg2;
        }

        public int divide(int arg1, int arg2)
        {
            return arg1 / arg2;
        }
    }
}
