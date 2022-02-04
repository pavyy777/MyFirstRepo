using System;
using System.Collections.Generic;
using System.Text;

using HMS.Entity.Models;


namespace HMS.DAL.Repository
{
     public interface IRegistrationIPDRepository
    {
        void AddPatient(RegistrationIPD registrationIPD);
        void UpdatePatient(RegistrationIPD registrationIPD);
        void DeletePatient(int PatientId);
        RegistrationIPD GetPatientById(int PatientId);
        IEnumerable<RegistrationIPD> GetPatients();
    }
}
