using DoctorTest.Models;
using System;
using System.Data.Entity;

namespace DoctorTest
{
    class ClinicContext : DbContext
    {
        public ClinicContext() : base("ClinicContext")
        {
        }

        DbSet<Doctor> Doctors { get; set; }
        DbSet<Patient> Patients { get; set; }
        DbSet<Journal> Journal { get; set; }
        DbSet<OutpatientCard> OutpatientCards { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DoctorMap());
            modelBuilder.Configurations.Add(new PatientMap());
            modelBuilder.Configurations.Add(new JournalMap());
            modelBuilder.Configurations.Add(new OutpatientCardMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
