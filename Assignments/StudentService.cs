using Mini_consol_app.Services.Implementations;
using Mini_consol_app.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

StudentService student2 = new();

namespace Mini_consol_app.Services.Implementations
{
    public class StudentService : IStudentService
    {
        StudentService student2 = new();
        public void Create(string Name, string Surname, double Average)
        {
            if (Name.Length>2 && Surname.Length>5 && Name.Length<15 && Surname.Length<15)
            {
                student2.Create("Samir", "Orucov", 70);
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz melumatlar yalnisdir.");
                Name = Console.ReadLine();
            }
        }
        public void Delete(int Id)
        {
            if (Id == student2.Id)
            {
                student2.Name = "";
                student2.Surname = "";
                student2.Average = 0;
                Console.WriteLine("Daxil olunan telebe sistemden silindi.");
            }
            else
            {
                Console.Write("Bele bir ID`e sahib telebe yoxdur. Yeniden daxil edin: ");
                Id = int.Parse(Console.ReadLine());
            }
        }
        public void Edit(int Id, string Name, string Surname)
        {
            if (Id == student2.Id && Name.Length > 2 && Surname.Length > 5 && Name.Length < 15 && Surname.Length < 15)
            {
                student1.Name = Name;
                student1.Surname = Surname;
                Console.WriteLine("Deyisiklikler qeyde alindi");
            }
            else
            {
                Console.WriteLine("Daxil etdiyiniz melumatlar yalnisdir");
            }
        }
        public void GetAll()
        {
            Console.WriteLine(student1.Name + " " + student1.Surname);
        }
        public void GetById(int Id)
        {
            if (Id == student1.Id)
            {
                Console.WriteLine(student1.Name + " " + student1.Surname);
            }
            else
            {
                Console.WriteLine("Daxil olunan ID yalnisdir");
                Id = int.Parse(Console.ReadLine());
            }
        }
    }
}
