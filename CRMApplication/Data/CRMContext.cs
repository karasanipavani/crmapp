using Microsoft.EntityFrameworkCore;
using CRMApplication.Models;
namespace CRMApplication.Data
{
    public class CRMContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Loan> Loans { get; set; }
        public DbSet<Deposit> Deposits { get; set; }

        public CRMContext(DbContextOptions<CRMContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define relationships and constraints if necessary
        }

    }
}
