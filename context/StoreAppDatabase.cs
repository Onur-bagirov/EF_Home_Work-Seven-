using EF_Home_Work_Seven_.EntityConfirguration;
using Microsoft.EntityFrameworkCore;
using StoreAppProject.Models;

namespace EF_Home_Work_Seven_.Context;

public class StoreAppDatabase : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Data Source=STHQ0128-09;Initial Catalog=StoreAppDataBase;User ID=admin;Password=admin;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<User> User { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CustomerConfirguration());
        modelBuilder.ApplyConfiguration(new OrderConfirguration());
        modelBuilder.ApplyConfiguration(new ProductConfirguration());
        modelBuilder.ApplyConfiguration(new UserConfirguration());
    }
}
