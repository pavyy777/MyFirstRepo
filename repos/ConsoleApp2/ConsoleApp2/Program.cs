using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
          //  bool debug = false;

            //Create a Person and make it say hello
            Person myPerson = new Person();
            myPerson.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            Student myStudent = new Student();
            myStudent.SetAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            Teacher myTeacher = new Teacher();
            // int a=Convert.ToInt32(25);

            myTeacher.SetAge(25);
            myTeacher.ShowAge1();
            myTeacher.Greet();
            myTeacher.Explain(); 
          //  Console.WriteLine(a);

           // if (debug)
                Console.ReadLine();
        }
    }
}
