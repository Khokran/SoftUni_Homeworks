using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCodeFirstTest.Data.Models
{
    public class Student
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength (NameMaxLength)]
        public string FirstName { get; set; }
        
        [MaxLength (NameMaxLength)]
        public string LastName { get; set; }

        public static int? Age { get; set; }                // ? означава , че не е задължителен Age-a

        [Column(TypeName ="nvarchar(10)")]                  // [Column("EGN")]  -  така може да се кръсти "EGN"
        public DateTime RegistrationDate { get; set; }
        public StudentType Type { get; set; }

    }
}
