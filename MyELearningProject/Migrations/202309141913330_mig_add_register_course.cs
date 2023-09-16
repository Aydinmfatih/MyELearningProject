namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_register_course : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseRegisters",
                c => new
                    {
                        CourseRegisterId = c.Int(nullable: false, identity: true),
                        StudentId = c.Int(nullable: false),
                        CourseId = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseRegisterId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.StudentId)
                .Index(t => t.CourseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseRegisters", "StudentId", "dbo.Students");
            DropForeignKey("dbo.CourseRegisters", "CourseId", "dbo.Courses");
            DropIndex("dbo.CourseRegisters", new[] { "CourseId" });
            DropIndex("dbo.CourseRegisters", new[] { "StudentId" });
            DropTable("dbo.CourseRegisters");
        }
    }
}
