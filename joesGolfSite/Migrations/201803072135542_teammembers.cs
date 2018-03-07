namespace joesGolfSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teammembers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Registerers", "TeamMember1", c => c.String());
            AddColumn("dbo.Registerers", "TeamMember2", c => c.String());
            AddColumn("dbo.Registerers", "TeamMember3", c => c.String());
            DropColumn("dbo.Registerers", "TeamMembers");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Registerers", "TeamMembers", c => c.String(nullable: false));
            DropColumn("dbo.Registerers", "TeamMember3");
            DropColumn("dbo.Registerers", "TeamMember2");
            DropColumn("dbo.Registerers", "TeamMember1");
        }
    }
}
