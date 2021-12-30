using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIGNMENT2
{
  public  class Student
   
    {  
        int rollno;
        string name;
        string course;
        int fee;    
        public void StudentDetails()
        {
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Your Roll Number:");
             int  rollno = Convert.ToInt32(Console.ReadLine());
           
            Console.WriteLine("enter ur course");
            string course= Console.ReadLine(); 

            Console.WriteLine("details");
            Console.WriteLine("Student Name :" + name);
            Console.WriteLine("Roll No :" + rollno);
            Console.WriteLine("course:" + course);
            Console.ReadLine();
        }

    }

}
