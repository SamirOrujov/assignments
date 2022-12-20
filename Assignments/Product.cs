using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Access_modifiers
{
    public class Product
    {
        public string name;
        public int price;
        private int _count;
        private int _totalIncome;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        public int TotalIncome
        {
            get { return _totalIncome; }
            set { _totalIncome = value; }
        }

        public void Sell()
        {
            if (_count>0)
            {
                _count--;
                _totalIncome += price;
                Console.WriteLine("Mehsuldan 1 eded satildi.");
            }
            else
            {
                Console.WriteLine("Mehsul qalmayib.");
            }
        }

        public Product(string name, int price, int count)
        {
            if (price<1 && count<=0 && string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Daxil etdiyiniz melumatlar yalnisdir.");
            }
            else
            {
                this.name = name;
                this.price = price;
                this._count = count;
                Console.WriteLine("Daxil etdiyiniz melumatlar saxlanildi");
            }
        }
    }
}
