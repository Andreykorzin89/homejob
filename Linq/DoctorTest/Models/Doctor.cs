using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;

namespace DoctorTest.Models
{
    class Doctor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public List<Journal> Patients { get; set; }
    }

    class DoctorMap : EntityTypeConfiguration<Doctor>
    {
        public DoctorMap()
        {
            HasKey(x => x.Id);
            HasMany(x => x.Patients);
        }
    }
}
