using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StoreAppProject.Models;
namespace EF_Home_Work_Seven_.EntityConfirguration
{
    class UserConfirguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.Property(p => p.Username).HasMaxLength(50).IsRequired();
            builder.Property(p => p.Password).IsRequired();

            builder.HasOne(u => u.Customer).WithOne(c => c.user).HasForeignKey<Customer>(c => c.ID_User);
        }
    }
}