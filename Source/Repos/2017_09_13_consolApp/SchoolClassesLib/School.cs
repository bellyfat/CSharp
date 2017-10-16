using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesLib
{
    public class School
    {
        public List<Class> classes = new List<Class>();
        public string Name { get; set; }
        public int StudentCount
        {
            get
            { 
                return classes.Sum(c => c.Students);
            }
        }

        public void addClass(Class theclass)
        {
            classes.Add(theclass);
        }
    }
}
