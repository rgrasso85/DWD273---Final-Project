using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentPlanner.Models
{
    [Table("Assignments")]
    public class Assignments
    {

        public int ID { get; set; }
        public string AssignmentName { get; set; }
        public DateTime DueDate { get; set; }
    }
}