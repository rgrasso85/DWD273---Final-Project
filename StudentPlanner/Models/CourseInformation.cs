using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlanner.Models
{
    [Table("CourseInformation")]
    public class CourseInformation
    {
        public int ID { get; set; }
        public int CourseTitle { get; set; }
        public int Assignment { get; set; }
        public int Progress { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CompletedDate { get; set; }

        [ForeignKey("CourseTitle")]
        public virtual Course CourseDescription { get; set; }
        [ForeignKey("Assignment")]
        public virtual Assignments AssignmentInformation { get; set; }
        [ForeignKey("Progress")]
        public virtual Progress ProgressPercentage { get; set; }

    }
}