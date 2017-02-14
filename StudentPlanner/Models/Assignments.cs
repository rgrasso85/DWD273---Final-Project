using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlanner.Models
{
    [Table("Assignments")]
    public class Assignments
    {

        public int ID { get; set; }
        [Display(Name = "Assignment")]
        public string AssignmentName { get; set; }
        [Display(Name = "Due Date")]
        public DateTime DueDate { get; set; }
        public int CourseID { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
    }
}