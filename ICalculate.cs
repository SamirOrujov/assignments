using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practice_task.Models.Models2
{

    internal interface ITest
    {

    }
    internal interface ICalculate
    {
        public void Sum();

        public void Divide();

        public void Multiply();
    }

    class Calculate : Animal, ICalculate, ITest
    {
        public void Divide()
        {
            Console.WriteLine(10/2);
        }

        public void Multiply()
        {
            throw new NotImplementedException();
        }

        public override void Sound()
        {
            throw new NotImplementedException();
        }

        public void Sum()
        {
            throw new NotImplementedException();
        }
    }
}
