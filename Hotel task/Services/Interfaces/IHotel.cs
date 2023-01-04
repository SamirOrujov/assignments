using Hotel_task.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_task.Services.Interfaces
{
    internal interface IHotel
    {
        public void Menu();
        public void Create();
        public void ShowAll();
        public void Reserve();
        public void Exit();
    }
}
