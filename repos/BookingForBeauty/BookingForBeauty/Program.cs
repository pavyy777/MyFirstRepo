using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingForBeauty
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Appoint.Schedule("7 / 25 / 2019 13:45:00");
            Appoint.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0));
            Appoint.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0));
            Appoint.Description(new DateTime(2019, 03, 29, 15, 0, 0));
            Appoint.AnniversaryDate();


        }
    }
}
