using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlanner.Models
{
    [Table("Course")]
    public class Course
    {
        public int ID { get; set; }
        public string CourseTitle { get; set; }
        public string CourseNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}