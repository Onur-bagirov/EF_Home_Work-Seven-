using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreAppProject.Models;
namespace EF_Home_Work_Seven_.EntityConfirguration
{
    class CustomerConfirguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customer");
            builder.Property(p => p.Name).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Surname).HasMaxLength(50).IsRequired();

            builder.HasMany(h => h.Orders).WithOne(o => o.Customer).HasForeignKey(h => h.ID_Customer);
        }
    }
}
