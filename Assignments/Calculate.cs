using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Calculator
{
    public class Calculate : ICalculate
    {
        public int input1;

        public string input2;

        public int input3;

        public int Sum()
        {
            int sum = input1 + input3;
            return sum;
        }

        public int Extract()
        {
            int extract = input1 - input3;
            return extract;
        }

        public int Multiply()
        {
            int multiply = input1 * input3;
            return multiply;
        }

        public int Divide()
        {
            int divide = input1 / input3;
            return divide;
        }
    }
}
