using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace YourNamespace.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PurchaseHistory> PurchaseHistories { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }

        

        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
