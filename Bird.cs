using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practice_task.Models.Models2
{
    internal abstract class Bird:Animal
    {
        public virtual void Fly()
        {
            Console.WriteLine("Fly as Bird");
        }
    }

    class Eagle : Bird
    {
        public override void Sound()
        {
            Console.WriteLine("Sound as Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly as Eagle");
        }
    }
}
