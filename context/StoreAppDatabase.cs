using Microsoft.EntityFrameworkCore;
using StoreAppProject.Models;

namespace EF_Home_Work_Seven_.context
{
    internal class StoreAppDatabase : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=WINDOWS_11_ONUR\\MSSQLSERVER01;Initial Catalog=StoreAppDataBase;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
        DbSet<Customer> Customer { get; set; }
        DbSet<Order> Order { get; set; }
        DbSet<Product> Product { get; set; }
        DbSet<User> User { get; set; }


    }
}
