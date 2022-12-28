using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_consol_app.Services.Interfaces
{
    public interface IStudentService
    {
        public void Create(string Name, string Surname, double Average);
        public void Delete(int Id);
        public void Edit(int Id, string Name, string Surname);
        public void GetAll();
        public void GetById(int Id);
    }
}
