﻿namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_imageurl_instructor : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "ImageUrl");
        }
    }
}