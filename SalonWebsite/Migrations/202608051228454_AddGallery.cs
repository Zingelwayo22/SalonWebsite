namespace SalonWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGallery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galleries", "Title", c => c.String(maxLength: 100));
            DropColumn("dbo.Galleries", "Caption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Galleries", "Caption", c => c.String());
            DropColumn("dbo.Galleries", "Title");
        }
    }
}
