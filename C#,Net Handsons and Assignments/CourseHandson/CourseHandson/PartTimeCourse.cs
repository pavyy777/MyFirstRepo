using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHandson
{
    class PartTimeCourse : Course
    {
        public int discount;
        public PartTimeCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            discount = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
           double t=total - (total * discount / 100);
            return t;
        }
    }
    
    
}
