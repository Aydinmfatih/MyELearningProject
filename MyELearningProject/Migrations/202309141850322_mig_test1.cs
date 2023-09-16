namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_test1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Instructors", "Instructor_InstructorId", "dbo.Instructors");
            DropIndex("dbo.Instructors", new[] { "Instructor_InstructorId" });
            DropColumn("dbo.Instructors", "Instructor_InstructorId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Instructors", "Instructor_InstructorId", c => c.Int());
            CreateIndex("dbo.Instructors", "Instructor_InstructorId");
            AddForeignKey("dbo.Instructors", "Instructor_InstructorId", "dbo.Instructors", "InstructorId");
        }
    }
}
