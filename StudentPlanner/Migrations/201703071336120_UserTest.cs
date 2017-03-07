namespace StudentPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UserTest : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Course", "UserID", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Course", "UserID");
        }
    }
}
