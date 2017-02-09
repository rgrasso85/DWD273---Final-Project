namespace StudentPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Assignments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AssignmentName = c.String(),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Course",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseTitle = c.String(),
                        CourseNumber = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.CourseInformation",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CourseTitle = c.Int(nullable: false),
                        Assignment = c.Int(nullable: false),
                        Progress = c.Int(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                        CompletedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Assignments", t => t.Assignment, cascadeDelete: true)
                .ForeignKey("dbo.Course", t => t.CourseTitle, cascadeDelete: true)
                .ForeignKey("dbo.Progress", t => t.Progress, cascadeDelete: true)
                .Index(t => t.CourseTitle)
                .Index(t => t.Assignment)
                .Index(t => t.Progress);
            
            CreateTable(
                "dbo.Progress",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProgressPercentage = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseInformation", "Progress", "dbo.Progress");
            DropForeignKey("dbo.CourseInformation", "CourseTitle", "dbo.Course");
            DropForeignKey("dbo.CourseInformation", "Assignment", "dbo.Assignments");
            DropIndex("dbo.CourseInformation", new[] { "Progress" });
            DropIndex("dbo.CourseInformation", new[] { "Assignment" });
            DropIndex("dbo.CourseInformation", new[] { "CourseTitle" });
            DropTable("dbo.Progress");
            DropTable("dbo.CourseInformation");
            DropTable("dbo.Course");
            DropTable("dbo.Assignments");
        }
    }
}
