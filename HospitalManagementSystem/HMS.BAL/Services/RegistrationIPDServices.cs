using System;
using System.Collections.Generic;
using System.Text;
using HMS.DAL.Repository;
using HMS.Entity.Models;

namespace HMS.BAL.Services
{
     public class RegistrationIPDServices
    {
        IRegistrationIPDRepository _registrationIPDRepository;
        public RegistrationIPDServices(IRegistrationIPDRepository registrationIPDRepository)
        {
            _registrationIPDRepository = registrationIPDRepository;
        }
        public void AddPatient(RegistrationIPD registrationIPD)
        {
            _registrationIPDRepository.AddPatient(registrationIPD);
        }
        public void DeletePatient(int PatientId)
        {
            _registrationIPDRepository.DeletePatient(PatientId);
        }
        public void GetPatientById(int PatientId)
        {
            _registrationIPDRepository.GetPatientById(PatientId);
        }
        public void UpdatePatient(RegistrationIPD registrationIPD)
        {
            _registrationIPDRepository.UpdatePatient(registrationIPD);
        }
        public void GetPatients()
        {
            _registrationIPDRepository.GetPatients();
        }


    }
   

  
}
