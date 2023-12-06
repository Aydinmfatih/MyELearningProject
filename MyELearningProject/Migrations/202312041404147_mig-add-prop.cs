﻿namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migaddprop : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Categories", "ImageUrl");
        }
    }
}
