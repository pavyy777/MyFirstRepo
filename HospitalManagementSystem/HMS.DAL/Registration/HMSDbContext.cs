using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HMS.Entity.Models;

namespace HMS.DAL.Registration
{
   public class HMSDbContext:DbContext
    {
        public HMSDbContext(DbContextOptions<HMSDbContext> options):base(options)
        {
                
        }
        
        public DbSet<RegistrationIPD> registrationIPD { get; set; }
        public DbSet<RegistrationOPD> registrationOPD { get; set; }

    }
}
