using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCarSystem.Data.Models
{
    public class Car
    {
        public int Id { get; set; }

        public DateTime Year { get; set; }

        [Required]
        [MaxLength(MaxLengthAttribute)]
        public string VIN { get; set; } 

    }
}
