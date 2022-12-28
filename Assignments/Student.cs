using Mini_consol_app.Services.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_consol_app
{
    public class Student : StudentService
    {
        StudentService student1 = new();
        private int _id;
        private string _name;
        private string _surname;
        private float _average;
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public float Average
        {
            get { return _average; }
            set { _average = value; }
        }

        public Student()
        {
            Id++;
        }
    }
}
