using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolClassesLib;
using System.Linq;
using System.Diagnostics;

namespace SchoolClassesLibTests
{
    /*
    Use Case: Manage classes in school
    Level: Sea

    Scenario:
    A school manager adds a class containing a name and 
    the number of students.

     */
    [TestClass]
    public class SchoolSystemTests
    {
        [TestMethod]
        public void CountStudents()
        {
            SchoolSystem sut = new SchoolSystem();
            sut.addSchool("EC Utbildning");
            School ECUtbildning = sut.getSchoolByName("EC Utbildning");
            Class class1 = new Class("SPO16", 17);
            Class class2 = new Class("SPO17", 15);
            ECUtbildning.addClass(class1);
            ECUtbildning.addClass(class2);
            
            Assert.AreEqual(2, sut.ClassCount);
            Assert.AreEqual(32, sut.StudentCount);
            Debug.WriteLine($"There are this many classes: {sut.ClassCount} and this many students in total of all schools: {sut.StudentCount}");
            
        }
    }
}
