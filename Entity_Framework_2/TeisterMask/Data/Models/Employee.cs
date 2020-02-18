namespace TeisterMask.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Employee
    {
        public int Id { get; set; }

        [MinLength(3), MaxLength(40), Required]
        public string Username { get; set; }

        [DataType(DataType.EmailAddress), Required]
        public string Email { get; set; }

        [DataType("^[0-9]{3}-[0-9]{3}-[0-9]{4}$"), Required]
        public string Phone { get; set; }
        public ICollection<EmployeeTask> EmployeesTasks { get; set; }

    }
}
