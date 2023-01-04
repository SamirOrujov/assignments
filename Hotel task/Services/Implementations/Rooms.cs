using Hotel_task.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_task.Services.Implementations
{
    internal class Rooms : IRooms
    {
        private static int _id;
        public int Id { get; set; }
        public int No { get; set; }
        public int Price { get; set; }
        public bool IsReserved { get; set; }
        public Rooms()
        {
            _id++;
            Id = _id;
        }
    }
}
