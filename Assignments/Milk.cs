using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    internal class Milk : Product
    {
        public int volume;
        public int fatRate;

        internal Milk(string name, int price, int count) : base(name, price, count)
        {
        }
    }
}
