using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asss2
{
   public class Program
    {
        static void Main(string[] args)
        {
            Person objperson = new Person();
            Student objstudent = new Student();
            objstudent.PersonDetails();
            objstudent.StudentDetails();
            objstudent.Calc();
            
            Console.ReadLine();


            

           
            
        }
    }
}