using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace HMS.Entity.Models
{
     public class RegistrationOPD
    {
        [Key]
        public int PatientId { get; set; }
        public string PatientName { get; set; }
        public int AdmissionDate { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string BloodGroup { get; set; }
        public string PatientIssue { get; set; }
        public string DoctorType { get; set; }

    }
}
