using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace DoctorTest.Models
{
    class Patient
    {
        public int Id { get; set; }
        public int OutpatientCardId { get; set; }
        public OutpatientCard OutpatientCard { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public List<Journal> Doctors { get; set; }
    }

    class PatientMap : EntityTypeConfiguration<Patient>
    {
        public PatientMap()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.OutpatientCard).WithRequiredPrincipal(x => x.Patient);

            HasMany(x => x.Doctors);
        }
    }
}
