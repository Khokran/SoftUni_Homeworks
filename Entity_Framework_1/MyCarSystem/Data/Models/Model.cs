using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyCarSystem.Data.Models
{
    public class Model
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxName)]
        public string Name { get; set; }

        [Required]
        [MaxLength(MaxModificationLength)]
        public string Modification { get; set; }

        public int Year { get; set; }

    }
}
