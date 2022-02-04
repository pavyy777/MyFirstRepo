using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace HMS.Entity.Models
{
    public class PharmacyMedIssue
    {
        public PharmacyStock pharmacyStock { get; set; }
        [ForeignKey("pharmacyStock")]

        public string MedCause { get; set; }

    }
}
