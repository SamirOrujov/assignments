using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_practice_task.Models.Models2
{
    internal abstract class Animal
    {
        public string Name { get; set; }

        public abstract void Sound();
    }
}
