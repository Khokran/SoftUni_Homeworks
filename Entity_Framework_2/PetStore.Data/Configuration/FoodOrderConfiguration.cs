namespace PetStore.Data.Configuration
{
    using Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class FoodOrderConfiguration : IEntityTypeConfiguration<FoodOrder>
    {
        public void Configure(EntityTypeBuilder<FoodOrder> foodOrder)
        {
            foodOrder.HasKey(fo => new { fo.FoodId, fo.OrderId });

            foodOrder
                .HasOne(fo => fo.Food)
                .WithMany(f => f.Orders)
                .HasForeignKey(fo => fo.FoodId)
                .OnDelete(DeleteBehavior.Restrict);

            foodOrder
                .HasOne(fo => fo.Order)
                .WithMany(f => f.Food)
                .HasForeignKey(f => f.OrderId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
