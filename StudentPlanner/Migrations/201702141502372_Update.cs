namespace StudentPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Assignments", "AssignmentDescription", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Assignments", "AssignmentDescription");
        }
    }
}
