namespace MyELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_list1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutLists",
                c => new
                    {
                        AboutListId = c.Int(nullable: false, identity: true),
                        AboutListTitle = c.String(),
                    })
                .PrimaryKey(t => t.AboutListId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AboutLists");
        }
    }
}
