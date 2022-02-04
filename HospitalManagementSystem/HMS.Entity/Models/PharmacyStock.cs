using System;
using System.Collections.Generic;
using System.Text;

namespace HMS.Entity.Models
{
    public class PharmacyStock
    {
        public string MedName { get; set; }
        public string MedCause { get; set; }
        public string MedAmount { get; set; }
        public bool AvailableStock { get; set; }
    }
}
