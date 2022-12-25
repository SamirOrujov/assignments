using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface ICalculate
    {
        public int Sum();
        public int Extract();
        public int Multiply();
        public int Divide();
    }
}
