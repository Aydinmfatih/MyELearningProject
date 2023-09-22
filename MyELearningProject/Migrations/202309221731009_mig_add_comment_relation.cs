namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_comment_relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Comments", "StudentId", c => c.Int(nullable: false));
            AddColumn("dbo.Comments", "CourseId", c => c.Int(nullable: false));
            CreateIndex("dbo.Comments", "StudentId");
            CreateIndex("dbo.Comments", "CourseId");
            AddForeignKey("dbo.Comments", "CourseId", "dbo.Courses", "CourseId", cascadeDelete: true);
            AddForeignKey("dbo.Comments", "StudentId", "dbo.Students", "StudentId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Comments", "StudentId", "dbo.Students");
            DropForeignKey("dbo.Comments", "CourseId", "dbo.Courses");
            DropIndex("dbo.Comments", new[] { "CourseId" });
            DropIndex("dbo.Comments", new[] { "StudentId" });
            DropColumn("dbo.Comments", "CourseId");
            DropColumn("dbo.Comments", "StudentId");
        }
    }
}
