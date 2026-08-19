namespace SalonWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWebsiteSettings : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebsiteSettings",
                c => new
                    {
                        WebsiteSettingsId = c.Int(nullable: false, identity: true),
                        SalonName = c.String(nullable: false),
                        Tagline = c.String(),
                        HeroHeading = c.String(),
                        HeroDescription = c.String(),
                        Logo = c.String(),
                        HeroImage = c.String(),
                    })
                .PrimaryKey(t => t.WebsiteSettingsId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebsiteSettings");
        }
    }
}
