namespace PetStore.Data.Models
{
    using static DataValidation;
    using System.Collections.Generic;
    public class Category
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; }

        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; }
        public ICollection<Pet> Pets { get; set; } = new HashSet<Pet>();
        public ICollection<Toy> Toys { get; set; } = new HashSet<Toy>();
        public ICollection<Food> Food { get; set; } = new HashSet<Food>();

    }
}
