using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Student
    {
        public void StudentDetails()
        {
            Console.Write("Enter Your Name:");
            string name = Console.ReadLine();

            Console.Write("Enter Your Roll Number:");
            int rollNo = Convert.ToInt32(Console.ReadLine());
          



            //Console.Write("Enter Your Fees to be paid:");
            //int fees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Students Details :");
            Console.WriteLine("Student Name :" + name);
            Console.WriteLine("Roll No :" + rollNo);
           // Console.WriteLine("Course :" + course);
             //Console.WriteLine("fees :" + fees);

        }
        public void Course()
        {
            Console.WriteLine("Choose Course Here: 1) C#  2) ASP.NET");
            string course = Console.ReadLine();

            Console.WriteLine("Course is:"+course);
            if (course.StartsWith("C#"))
            {
                
                Console.WriteLine("Total fee is Rs 2000 for C# Course\nYou have to pay Rs 2000 now");
                int pay = Convert.ToInt32(Console.ReadLine());
                if (pay == 2000)
                {
                    Console.WriteLine("You have to paid 2000 Rupees");
                }
                else
                {
                    Console.WriteLine(  "You Paid :"+pay+" Rupees");
                    int a = 2000 - pay;
                    Console.WriteLine("you have to pay remaining :" + a + " Rupees");
                }
                
            }
            else
            {
              /  Console.WriteLine("You have choosen invalid course\n");

            }
            if (course.StartsWith("ASP.NET"))
            {
                Console.WriteLine("Total fee is Rs 3000 for ASP.NET Course\nYou have to pay Rs 3000 now");
                int pay2 = Convert.ToInt32(Console.ReadLine());
                if (pay2 == 3000)
                {
                    Console.WriteLine("You have paid 3000 Rupees");
                }
                else
                {
                    Console.WriteLine("You Paid: "+pay2+" Rupees");
                    int b = 3000 - pay2;
                    Console.WriteLine("you have to pay remaining : " + b + " Rupees");


                }
                

            }
            else
            {
                //Console.WriteLine("You have choosen invalid course\n ");
            }
        } 
    } }
