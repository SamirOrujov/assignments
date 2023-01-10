using Student_consol_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_consol_app.Services.Interfaces
{
    internal interface IStudentS
    {
        public void Create(string name, string surname, int average);
        public void Edit(int id, string name, string surname, int average);
        public void Delete(int id);
        public Student[] GetAll();
    }
}
