using Mini_consol_app.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_consol_app.Services.Implementations
{
    public class Group : Student
    {
        public int Id 
        {
            get { return Id; }
            set { Id = value; } 
        }

        public string Name 
        { 
            get { return Name; } 
            set { Name = value; }
        }

        public string[] Students
        {
            get { return Students; }
            set { Students = value; }
        }
    }
}
