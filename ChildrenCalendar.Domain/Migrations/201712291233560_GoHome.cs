namespace ChildrenCalendar.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GoHome : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Meals", "UserId", c => c.String());
            AddColumn("dbo.NatFeeds", "UserId", c => c.String());
            AddColumn("dbo.Sleeps", "UserId", c => c.String());
            AddColumn("dbo.Vaccinations", "UserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Vaccinations", "UserId");
            DropColumn("dbo.Sleeps", "UserId");
            DropColumn("dbo.NatFeeds", "UserId");
            DropColumn("dbo.Meals", "UserId");
        }
    }
}
