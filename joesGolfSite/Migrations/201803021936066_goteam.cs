namespace joesGolfSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class goteam : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registerers", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Registerers", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Registerers", "EmailAddress", c => c.String(nullable: false));
            AlterColumn("dbo.Registerers", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Registerers", "TeamName", c => c.String(nullable: false));
            AlterColumn("dbo.Registerers", "ShirtSize", c => c.String(nullable: false));
            AlterColumn("dbo.Registerers", "TeamMembers", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registerers", "TeamMembers", c => c.String());
            AlterColumn("dbo.Registerers", "ShirtSize", c => c.String());
            AlterColumn("dbo.Registerers", "TeamName", c => c.String());
            AlterColumn("dbo.Registerers", "Phone", c => c.String());
            AlterColumn("dbo.Registerers", "EmailAddress", c => c.String());
            AlterColumn("dbo.Registerers", "LastName", c => c.String());
            AlterColumn("dbo.Registerers", "FirstName", c => c.String());
        }
    }
}
