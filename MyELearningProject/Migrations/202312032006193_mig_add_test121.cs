namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_test121 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Abouts", "AboutList");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Abouts", "AboutList", c => c.String());
        }
    }
}
