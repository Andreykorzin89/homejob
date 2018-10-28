using System;
using System.Data.Entity.ModelConfiguration;

namespace DoctorTest.Models
{
    class OutpatientCard
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient Patient { get; set; }
        public string Information { get; set; }
        public DateTime ReceptionDate { get; set; }
    }

    class OutpatientCardMap : EntityTypeConfiguration<OutpatientCard>
    {
        public OutpatientCardMap()
        {
            HasKey(x => x.Id);

            HasRequired(x => x.Patient).WithRequiredDependent(x => x.OutpatientCard);
        }
    }
}
