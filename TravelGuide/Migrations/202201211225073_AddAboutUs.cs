namespace TravelGuide.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAboutUs : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AboutUs", "Name", c => c.String());
            AddColumn("dbo.AboutUs", "Description", c => c.String());
            DropColumn("dbo.AboutUs", "Script");
            DropColumn("dbo.AboutUs", "Deneme");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AboutUs", "Deneme", c => c.String());
            AddColumn("dbo.AboutUs", "Script", c => c.String());
            DropColumn("dbo.AboutUs", "Description");
            DropColumn("dbo.AboutUs", "Name");
        }
    }
}
