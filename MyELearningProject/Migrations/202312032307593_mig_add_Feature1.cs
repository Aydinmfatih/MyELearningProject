﻿namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_Feature1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CarousellFeatures", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CarousellFeatures", "ImageUrl");
        }
    }
}
