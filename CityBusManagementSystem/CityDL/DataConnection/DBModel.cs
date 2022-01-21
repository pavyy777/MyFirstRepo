using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityDL.DataConnection
{
    
        public class DBModel
        {


          
            public int Route_no { get; set; }
            public int No_of_Stops { get; set; }
            public string Start_time { get; set; }
            public string End_time { get; set; }
           

        }
    public class EmployeeModel
    {
        public int Employee_ID { get; set; }
        public string Employee_Name{ get; set; }
        public string Designation { get; set; }
   
    }
    public class BusDetailsModel
    {
        public string Bus_name { get; set; }
        public int Bus_Number { get; set; }
        public int Route_No { get; set; }
        public string Arrival_Time { get; set; }
        public string Departure_time { get; set; }

    }

}
