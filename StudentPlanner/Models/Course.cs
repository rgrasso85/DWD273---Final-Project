using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlanner.Models
{
    [Table("Course")]
    public class Course
    {
        public int ID { get; set; }
        [Display(Name ="Course Title")]
        public string CourseTitle { get; set; }
        public string CourseNumber { get; set; }
    }
}