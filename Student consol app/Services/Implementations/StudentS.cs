using Student_consol_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student_consol_app.Services.Interfaces;

namespace Student_consol_app.Services.Implementations
{
    internal class StudentS: IStudentS
    {
        Group group = new Group();
        public void Create(string name, string surname, int average)
        {
            Student student = new Student
            {
                Name = name,
                SurName = surname,
                Average = average
            };
            Array.Resize(ref group.Students, group.Students.Length + 1);

            group.Students[group.Students.Length - 1] = student;



        }

        public void Delete(int id)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i] = group.Students[group.Students.Length - 1];
                    Array.Resize(ref group.Students, group.Students.Length - 1);
                    return;
                }
            }
            Console.WriteLine("Bu id`li telebe yoxdur.");
        }

        public void Edit(int id, string name, string surname, int avarage)
        {
            for (int i = 0; i < group.Students.Length; i++)
            {
                if (group.Students[i].Id == id)
                {
                    group.Students[i].Name = name;
                    group.Students[i].SurName = surname;
                    group.Students[i].Average = avarage;
                    return;
                }
            }
            Console.WriteLine("Bu id`li telebe yoxdur.");
        }

        public Student[] GetAll()
        {
            return group.Students;
        }
    }
}