namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_test12 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutFeatures",
                c => new
                    {
                        AboutFeatureId = c.Int(nullable: false, identity: true),
                        AboutIcon = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.AboutFeatureId);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ContentTitle = c.String(),
                        Description = c.String(),
                        AboutList = c.String(),
                    })
                .PrimaryKey(t => t.AboutId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutFeatures");
        }
    }
}
