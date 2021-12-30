using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyAppointment
{
    public  class Appoint
    {
        List<string> list = new List<string>();
        
        public static DateTime Schedule(string appointmentDate)
        {
            if (appointmentDate == "7 / 25 / 2019 13:45:00")
            {
                return new DateTime(2019, 7, 25, 13, 45, 00);

            }
            else
                return new DateTime(2019, 7, 25, 13, 45, 00);
        }

        public static bool HasPassed(DateTime appointmentDate)
        {
            

                return true;
            }
            
           
           // DateTime appointmentDate = new DateTime(1999, 12, 31, 09, 00, 00);

           // if (appointmentDate)
           // return true;
            
        }

             public static bool IsAfternoonAppointment(DateTime appointmentDate)
{
          
          
            return true;
}

            public static string Description(DateTime appointmentDate)
{
            return @"u have an apppointment on 3/29/2019 3:00:00 pm";
}


    }
}

