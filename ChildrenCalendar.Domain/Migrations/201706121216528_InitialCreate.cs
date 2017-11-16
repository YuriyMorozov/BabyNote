namespace ChildrenCalendar.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Sleeps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: true),
                        AwakeHour = c.Int(),
                        AwakeMinute = c.Int(),
                        AsleepHour = c.Int(),
                        AsleepMinute = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sleeps");
        }
    }
}
