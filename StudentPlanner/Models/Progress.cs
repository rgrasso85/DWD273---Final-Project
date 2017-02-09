using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentPlanner.Models
{
    [Table("Progress")]
    public class Progress
    {
        public int ID { get; set; }
        public string ProgressPercentage { get; set; }
    }
}