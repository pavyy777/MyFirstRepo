using System;
using System.Collections.Generic;
using System.Text;
using HMS.Entity.Models;

namespace HMS.DAL.Repository
{
     public interface IRegistrationOPDRepository
    {
        void AddPatient(RegistrationOPD registrationOPD);
        void UpdatePatient(RegistrationOPD registrationOPD);
        void DeletePatient(int PatientId);
        RegistrationOPD GetPatientById(int PatientId);
        IEnumerable<RegistrationOPD> GetPatients();
    }
}
