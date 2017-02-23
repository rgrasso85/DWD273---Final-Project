namespace StudentPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Progress : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "Progress", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Assignments", "Progress");
        }
    }
}
