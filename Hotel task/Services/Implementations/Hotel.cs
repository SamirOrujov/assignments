using Hotel_task.Services.Interfaces;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_task.Services.Implementations
{
    internal class Hotel : IHotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Rooms[] Room = { };
        public int input { get; set; }
        public Hotel()
        {
            Menu();
            Create();
            ShowAll();
            Reserve();
            Exit();
        }

        public void Menu()
        {
            Console.WriteLine("1. Otaq yarat");
            Console.WriteLine("2. Hamisin goster");
            Console.WriteLine("3. Rezerv et");
            Console.WriteLine("4. Cixis");
            input = int.Parse(Console.ReadLine());
        }

        public void Create()
        {
            while (input==1)
            {
                Console.Clear();
                Console.WriteLine("Otagin nomre ve qiymetini daxil edin: ");
                int no = int.Parse(Console.ReadLine());
                int price = int.Parse(Console.ReadLine());
                Rooms room = new()
                {
                    No = no,
                    Price = price
                };
                Array.Resize(ref Room, Room.Length+1);
                Room[Room.Length - 1] = room;
                Menu();
            }
        }

        public void Reserve()
        {
            while (input == 3)
            {
                Console.Clear();
                Console.WriteLine("Rezerv ucun otag id daxil edin: ");
                int id = int.Parse(Console.ReadLine());
                for (int i = 0; i < Room.Length; i++)
                {
                    if (Room[i].Id == id && Room[i].IsReserved == false)
                    {
                        Room[i].IsReserved = true;
                        Console.WriteLine("Rezerv olundu");
                    }
                    else if (Room[i].Id == id && Room[i].IsReserved == true)
                    {
                        Console.WriteLine("Istediyiniz otaq doludur. Basqasini sechin: ");
                        id = int.Parse(Console.ReadLine());
                    }
                }
                Menu();
            }
        }

        public void ShowAll()
        {
            while (input==2)
            {
                Console.Clear();
                for (int i = 0; i < Room.Length; i++)
                {
                    if (Room[i].IsReserved==false)
                    {
                        Console.WriteLine($"Otagin id: {Room[i].Id}\n" +
                            $"Otagin nomresi: {Room[i].No}\n" +
                            $"Otagin qiymeti: {Room[i].Price}\n" +
                            $"Otag rezerv deyil\n");
                    }
                    else
                    {
                        Console.WriteLine($"Otagin id: {Room[i].Id}\n" +
                            $"Otagin nomresi: {Room[i].No}\n" +
                            $"Otagin qiymeti: {Room[i].Price}\n" +
                            $"Otag rezervdir\n");
                    }
                }
                Menu();
            }
        }
        public void Exit()
        {
            while (input==4)
            {
                Console.Clear();
                Console.WriteLine("Cixis edildi..");
                return;
            }
        }
    }
}
