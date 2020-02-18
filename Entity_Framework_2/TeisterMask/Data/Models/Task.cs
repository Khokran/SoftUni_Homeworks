namespace TeisterMask.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public class Task
    {
        public int Id { get; set; }

        [MinLength(2), MaxLength(40), Required]
        public string Name { get; set; }

        [Required]
        public DateTime OpenDate { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public IEnumerable<ExecutionType> ExecutionType { get; set; } 

        [Required]
        public IEnumerable<LabelType> LabelType { get; set; }

        [Required]
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        public ICollection<EmployeeTask> EmployeesTasks { get; set; }

       
    }
}
