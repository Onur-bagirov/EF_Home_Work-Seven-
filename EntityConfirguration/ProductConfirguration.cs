using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreAppProject.Models;
namespace EF_Home_Work_Seven_.EntityConfirguration
{
    class ProductConfirguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Price).IsRequired();
            builder.Property(x => x.Description).IsRequired();
        }
    }
}
