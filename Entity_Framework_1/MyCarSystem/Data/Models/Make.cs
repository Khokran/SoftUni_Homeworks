using System;
using System.Collections.Generic;
using System.Text;

namespace MyCarSystem.Data.Models
{
    public class Make
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]


    }
}
