
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HMS.DAL.Repository;
using HMS.Entity.Models;
using System.Linq;

namespace HMS.BAL.Services
{
     public class RegistrationOPDServices
    {
        IRegistrationOPDRepository _registrationOPDRepository;
        public RegistrationOPDServices(IRegistrationOPDRepository registrationOPDRepository)
        {
            _registrationOPDRepository = registrationOPDRepository;
        }
        public void AddPatient(RegistrationOPD registrationOPD)
        {
            _registrationOPDRepository.AddPatient(registrationOPD);
        }
        public void DeletePatient(int PatientId)
        {
            _registrationOPDRepository.DeletePatient(PatientId);
        }
        public void GetPatientById(int PatientId)
        {
            _registrationOPDRepository.GetPatientById(PatientId);
        }
        public void UpdatePatient(RegistrationOPD registrationOPD)
        {
            _registrationOPDRepository.UpdatePatient(registrationOPD);
        }
        public void GetPatients()
        {
            _registrationOPDRepository.GetPatients();
        }
    }
}
