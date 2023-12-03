namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_Feature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CarousellFeatures",
                c => new
                    {
                        CarousellFeatureId = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Title2 = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CarousellFeatureId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CarousellFeatures");
        }
    }
}
