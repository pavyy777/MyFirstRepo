using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HMS.Entity.Models
{
     public class AdminDoctor
    {
        [Key]
        public int DoctorId { get; set; }
 
        public string  DoctorName { get; set; }
        public string  DoctorQualification { get; set; }
        public string DoctorSpecialization { get; set; }
        
        public int ConsultFee { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string ReEnterPassword { get; set; }



    }
}
