using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHandson
{
    public class Course
    {

        public string name;
        public int duration;
        public int fee;

        public Course(string name, int duration, int fee)
        {
            this.name = name;
            this.duration = duration;
            this.fee = fee;
        }


        public void Print()
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Duration(In Months) : " + duration.ToString());
            Console.WriteLine("Fee : " + fee.ToString());
            Console.WriteLine("Total fee : " + GetTotalFee().ToString());
        }


        public virtual double GetTotalFee()
        {
            return fee * duration;
        }
    }
}

    


        


       
    

