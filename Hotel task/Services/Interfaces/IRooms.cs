using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_task.Services.Interfaces
{
    internal interface IRooms
    {
        public int Id { get; set; }
        public int No { get; set; }
        public int Price { get; set; }
        public bool IsReserved { get; set; }
    }
}
