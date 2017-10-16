using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolClassesLib
{
    public class SchoolSystem
    {


        public List<School> schoolList = new List<School>();

        public int ClassCount {
            get
            {
                return schoolList.SelectMany(school => school.classes).Count();
            }}
        public int StudentCount
        {
            get {
                return schoolList.Sum(school => school.StudentCount);
            }
        }

        public void addSchool(string schoolName)
        {
            schoolList.Add(new School { Name = schoolName   });
        }
        public School getSchoolByName(string schoolName)
        {
            return schoolList.FirstOrDefault(school => school.Name == schoolName);
        }
    }
}
