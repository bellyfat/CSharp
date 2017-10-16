using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesLib
{
    public class Class
    {
        public string Name;
        public int Students;
        public string Description;

        public Class(string classname, int students)
        {
            this.Name = classname;
            this.Students = students;
        }
        public Class()
        {
            this.Name = "Unnamed";
        }
    }
}
