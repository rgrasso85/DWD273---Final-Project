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
        [Display(Name = "Description")]
        public string AssignmentDescription { get; set; }
        [Display(Name = "Due Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DueDate { get; set; }
        public int CourseID { get; set; }

        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
    }
}