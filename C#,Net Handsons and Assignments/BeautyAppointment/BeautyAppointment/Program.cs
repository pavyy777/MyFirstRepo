using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyAppointment
{
   public class Program
    {
        static void Main(string[] args)
        {
           // List<string> list = new List<string>();
            
             Appointment.Schedule("7 / 25 / 2019 13:45:00");
           
           // Console.ReadLine();
           // list.Add("7 / 25 / 2019 13:45:00");
            Appointment.HasPassed(new DateTime(1999, 12, 31, 09, 00, 00));
           // list.Add("1999, 12, 31, 09, 00, 00");
            Console.ReadLine();
          // foreach(var item in list)
           // {
             //   Console.WriteLine(item);
             //   Console.ReadLine();
          //  }
            //list.Add("1999, 12, 31, 9, 0, 0");
            Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 00, 00));
           // list.Add("2019, 03, 29, 15, 00, 00");
            
            Appointment.Description(new DateTime(2019, 03, 29, 15, 00, 00));
            




            
            Console.ReadLine();


        
        }
    }
}
