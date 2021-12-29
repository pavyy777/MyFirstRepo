using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandellingApp
{
    class Student:House
    {
        public Student()
        {
            Console.WriteLine("hdg");
        }
        public Student(int id,string name)
        {
            Console.WriteLine(id);
            Console.WriteLine(name);

        }
        public Student(string batch)
        {
            Console.WriteLine("batch is:"+ batch);
        }

    }
    class staff : Student
    {
        public void StaffStudent()
        {
            Student objstudent = new Student("pavan");
            //objstudent.StudentData(11, "54");
           //objstudent.StudentData("ef");
            Console.ReadLine();
        }
    }
}
