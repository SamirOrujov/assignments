using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practice_task.Models1.Models2
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void Test()
        {
            Console.WriteLine("test");
        }

        public abstract void AMethod();

        public virtual void Sum()
        {
            Console.WriteLine(10 + 5);
        }

    }
}
