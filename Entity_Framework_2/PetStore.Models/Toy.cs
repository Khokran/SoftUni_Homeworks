﻿
namespace PetStore.Data.Models
{
    using static DataValidation;
    using System.Collections.Generic;
    public class Toy
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ToyOrder> Orders { get; set; } = new HashSet<ToyOrder>();

    }
}
