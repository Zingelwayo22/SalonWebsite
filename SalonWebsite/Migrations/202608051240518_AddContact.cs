namespace SalonWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddContact : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "SalonName", c => c.String(nullable: false));
            AddColumn("dbo.Contacts", "OpeningHours", c => c.String());
            AlterColumn("dbo.Contacts", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Address", c => c.String());
            DropColumn("dbo.Contacts", "OpeningHours");
            DropColumn("dbo.Contacts", "SalonName");
        }
    }
}
