namespace SalonWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateSalonModels : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Abouts", "Title", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Abouts", "Title", c => c.String(nullable: false));
        }
    }
}
