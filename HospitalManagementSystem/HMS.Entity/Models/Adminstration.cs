using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HMS.Entity.Models
{
     public class Adminstration
    {
        [Key]
        public int EmployeeId { get; set; }
        public int Employee { get; set; }
        public string  DoctorName { get; set; }
        public string DoctorType { get; set; }
        public string  DoctorMaster { get; set; }
        public int ConsultFee { get; set; }
        


    }
}
