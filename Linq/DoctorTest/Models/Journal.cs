using System;
using System.Data.Entity.ModelConfiguration;

namespace DoctorTest.Models
{
    class Journal
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public DateTime ReceptionDate { get; set; }
    }

    class JournalMap : EntityTypeConfiguration<Journal>
    {
        public JournalMap()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.Doctor);
            HasRequired(x => x.Patient);
        }
    }
}
