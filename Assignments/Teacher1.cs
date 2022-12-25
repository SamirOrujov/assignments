using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practice_task.Models1.Models2
{
    internal class Teacher : Person
    {
        public override void AMethod()
        {
            throw new NotImplementedException();
        }
        public override void Sum()
        {
            Console.WriteLine(100 + 200);
        }
    }
}
