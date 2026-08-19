namespace SalonWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateGallery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Galleries", "Description", c => c.String());
            AddColumn("dbo.Galleries", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Galleries", "DisplayOrder", c => c.Int(nullable: false));
            AlterColumn("dbo.Galleries", "Title", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Galleries", "Title", c => c.String(maxLength: 100));
            DropColumn("dbo.Galleries", "DisplayOrder");
            DropColumn("dbo.Galleries", "IsActive");
            DropColumn("dbo.Galleries", "Description");
        }
    }
}
