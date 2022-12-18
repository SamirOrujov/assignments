using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace C_task_class
{
    public class Student
    {
        public string name;
        public string surName;
        public int group;
        public int point;
        public bool isGraduated;

        public void Create(string _name, string _surName, int _group, int _point, bool _isGraduated)
        {
            name = _name;
            surName = _surName;
            group = _group;
            point = _point;
            isGraduated = _isGraduated;
        }

        public void NameAndSurname()
        {
            string adSoyad = name + " " + surName;
            Console.WriteLine(adSoyad);
        }

        public void AllValues()
        {
            if (isGraduated == true)
            {
                Console.WriteLine(name + " " + surName + " " +
            group + " " + point + " " + "Mezundur");
            }
            else
            {
                Console.WriteLine(name + " " + surName + " " +
            group + " " + point + " " + "Mezun deyil");
            }
        }

        public void Exam()
        {
            if (point >= 80)
                {
                Console.WriteLine("2ci imtahana giris mumkundur.");
                }
                else
                {
                Console.WriteLine("2ci imtahana giris mumkun deyil.");
                }
        }
    }
}