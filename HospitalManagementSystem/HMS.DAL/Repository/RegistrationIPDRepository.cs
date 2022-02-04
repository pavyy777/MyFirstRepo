using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HMS.DAL.Registration;
using HMS.Entity.Models;
using System.Linq;


namespace HMS.DAL.Repository
{
     public class RegistrationIPDRepository:IRegistrationIPDRepository
    {
        HMSDbContext _hMSDbContext;
        public RegistrationIPDRepository(HMSDbContext hMSDbContext)
        {
            _hMSDbContext=hMSDbContext;
        }
        public void AddPatient(RegistrationIPD registrationIPD)
        {
            _hMSDbContext.registrationIPD.Add(registrationIPD);
            _hMSDbContext.SaveChanges();
        }

        public void DeletePatient(int PatientId)
        {
             var registrationIPD = _hMSDbContext.registrationIPD.Find(PatientId);
            _hMSDbContext.registrationIPD.Remove(registrationIPD);
            _hMSDbContext.SaveChanges();
           
        }
        

        public RegistrationIPD GetPatientById(int PatientId)
        {
            return _hMSDbContext.registrationIPD.Find(PatientId);
        }

        public IEnumerable<RegistrationIPD> GetPatients()
        {
            return _hMSDbContext.registrationIPD.ToList();
        }

        public void UpdatePatient(RegistrationIPD registrationIPD)
        {
            _hMSDbContext.Entry(registrationIPD).State = EntityState.Modified;
            _hMSDbContext.SaveChanges();
        }
    }
}



