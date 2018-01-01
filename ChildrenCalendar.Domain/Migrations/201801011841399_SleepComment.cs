namespace ChildrenCalendar.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SleepComment : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Sleeps", "Comment", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Sleeps", "Comment");
        }
    }
}
