using System;
using NUnit.Framework;
using System.Collections;

namespace CSharpCode.Classes
{
    [TestFixture]
    class ArrayListClass
    {
        [Test]
        public void StudentsTest() 
        {
            ArrayList students = new ArrayList();

            students.Add(new Student { id = 1, name = "Pepe", surname = "Roca" });
            students.Add(new Student { id = 2, name = "Juan", surname = "Rivas" });
            students.Add(new Student { id = 3, name = "Rosa", surname = "Velarde" });

            Student s1 = (Student)students[0];

            Assert.AreEqual(s1.name, "Pepe");
        }
    }

    public class Student
    {
        public int id {set; get;}
        public string name {set; get;}
        public string surname {set; get;}
    }
}
