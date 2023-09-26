namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_review : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        StudentId = c.Int(nullable: false),
                        ReviewScore = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.StudentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reviews", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Reviews", "CourseId", "dbo.Courses");
            DropIndex("dbo.Reviews", new[] { "StudentId" });
            DropIndex("dbo.Reviews", new[] { "CourseId" });
            DropTable("dbo.Reviews");
        }
    }
}
