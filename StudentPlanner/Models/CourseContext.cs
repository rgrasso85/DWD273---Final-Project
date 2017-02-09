using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StudentPlanner.Models
{
    public class CourseContext : DbContext
    {
        public virtual DbSet<CourseInformation> CourseInformation{ get; set; }
        public virtual DbSet<Assignments> Assignments { get; set; }
        public virtual DbSet<Course> Course { get; set; }

        public CourseContext() : base("CourseContext")
        {
        }

    }
}