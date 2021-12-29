using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            //Create a Person and make it say hello
            person myPerson = new person();
            myPerson.Greet();

            /*Create a student, set his age to 21, 
              tell him to Greet and display his age*/
            student myStudent = new student();
          // myStudent.SetAge(21);
           // myStudent.Greet();
           // myStudent.ShowAge();

            /*Create a teacher, 30 years old, 
             *ask him to say hello and then explain*/
            teacher myTeacher = new teacher();
            myTeacher.SetAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            //if (debug)
                Console.ReadLine();

        }
    }
}
