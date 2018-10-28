namespace DoctorTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Specialty = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DoctorId = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        ReceptionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.PatientId, cascadeDelete: true)
                .ForeignKey("dbo.Doctors", t => t.DoctorId, cascadeDelete: true)
                .Index(t => t.DoctorId)
                .Index(t => t.PatientId);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OutpatientCardId = c.Int(nullable: false),
                        Name = c.String(),
                        Birthday = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.OutpatientCards",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        PatientId = c.Int(nullable: false),
                        Information = c.String(),
                        ReceptionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Patients", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Journals", "DoctorId", "dbo.Doctors");
            DropForeignKey("dbo.Journals", "PatientId", "dbo.Patients");
            DropForeignKey("dbo.OutpatientCards", "Id", "dbo.Patients");
            DropIndex("dbo.OutpatientCards", new[] { "Id" });
            DropIndex("dbo.Journals", new[] { "PatientId" });
            DropIndex("dbo.Journals", new[] { "DoctorId" });
            DropTable("dbo.OutpatientCards");
            DropTable("dbo.Patients");
            DropTable("dbo.Journals");
            DropTable("dbo.Doctors");
        }
    }
}
