using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreAppProject.Models;
namespace EF_Home_Work_Seven_.EntityConfirguration
{
    class OrderConfirguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.Property(p => p.TotalPrice).IsRequired();

            builder.HasMany(h => h.Products).WithMany(x => x.Order).UsingEntity(j => j.ToTable("OrderProducts"));
        }
    }
}
