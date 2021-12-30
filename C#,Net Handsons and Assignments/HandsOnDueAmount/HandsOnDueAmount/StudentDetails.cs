using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDueAmount
{
    class StudentDetails
    {
        double ServiceTax = 0.123;

        public int RollNo { get; set; }
        public string Name { get; set; }
        public string CourseJoined { get; set; }
        public double FeePaid { get; set; }
        
        
       


        public double  Payment(double amount)
        {
            FeePaid += amount* ServiceTax;
            return FeePaid;
        }
        public StudentDetails(int rollNo, string name, string courseJoined)
        {
            RollNo = rollNo;
            Name = name;
            CourseJoined = courseJoined;
        }

        


        public double TotalFee
        {
            get
            {
                if (CourseJoined == "C#")
                {
                    double r = 2000 * ServiceTax;
                    return r;
                }
                else if (CourseJoined == "ASP.NET")
                {
                    double s = 3000 * ServiceTax;
                    return s;
                   }

                return 0;    
            }
        }
       
        public double DueAmount
        {
            get
            {

                double DAmount = (TotalFee - FeePaid) *ServiceTax;
                return DAmount;
            }
        }

         public void Print()
        {
            Console.WriteLine("Student Name:"+ Name);
            Console.WriteLine("Roll No: "+ RollNo);
            Console.WriteLine("Course Joined: "+CourseJoined);
            Console.WriteLine("Total Fee: "+TotalFee);
            Console.WriteLine("Fee Paid So Far: " +FeePaid);
            Console.WriteLine("Due Amount: "+DueAmount);
        }
    }
   /* public class Tax
    {
        public double ServiceTax { get; set; }


        public double DueAmount { get; set; }


        public double TotalFee
        {
            get
            {
                return DueAmount + DueAmount * ServiceTax;
            }
        }


        public Tax()
        {
            ServiceTax = 0.123;
        }
    }*/
}


      

       

        
       