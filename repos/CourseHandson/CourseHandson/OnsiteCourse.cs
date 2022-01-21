using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseHandson
{
    class OnsiteCourse : Course
    {
        public double charge;
        public OnsiteCourse(string name, int duration, int fee) : base(name, duration, fee)
        {
            charge = 10;
        }


        public override double GetTotalFee()
        {
            var total = fee * duration;
            return total + (total * charge / 100);
        }
    }
}
