using System;
using System.Collections.Generic;
using System.Text;
using HMS.DAL.Registration;
using HMS.Entity.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;



namespace HMS.DAL.Repository
{
     public class RegistrationOPDRepository:IRegistrationOPDRepository
    {
        HMSDbContext _hMSDbContext;
        public RegistrationOPDRepository(HMSDbContext hMSDbContext)
        {
            _hMSDbContext = hMSDbContext;
        }
        public void AddPatient(RegistrationOPD registrationOPD)
        {
            _hMSDbContext.registrationOPD.Add(registrationOPD);
            _hMSDbContext.SaveChanges();
        }

        public void DeletePatient(int PatientId)
        {
            var registrationOPD = _hMSDbContext.registrationOPD.Find(PatientId);
            _hMSDbContext.registrationOPD.Remove(registrationOPD);
            _hMSDbContext.SaveChanges();

        }


        public RegistrationOPD GetPatientById(int PatientId)
        {
            return _hMSDbContext.registrationOPD.Find(PatientId);
        }

        public IEnumerable<RegistrationOPD> GetPatients()
        {
            return _hMSDbContext.registrationOPD.ToList();
        }

        public void UpdatePatient(RegistrationOPD registrationOPD)
        {
            _hMSDbContext.Entry(registrationOPD).State = EntityState.Modified;
            _hMSDbContext.SaveChanges();
        }
    }
}
