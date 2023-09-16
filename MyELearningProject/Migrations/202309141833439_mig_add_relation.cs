namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Courses", "Category_CategorId", c => c.Int());
            CreateIndex("dbo.Courses", "Category_CategorId");
            AddForeignKey("dbo.Courses", "Category_CategorId", "dbo.Categories", "CategorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Category_CategorId", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "Category_CategorId" });
            DropColumn("dbo.Courses", "Category_CategorId");
            DropColumn("dbo.Courses", "CategoryId");
        }
    }
}
