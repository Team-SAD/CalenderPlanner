using System.Linq;
using Microsoft.EntityFrameworkCore;
using CalenderPlanner.Domain.Models;

namespace CalenderPlanner.Storing
{
  public class CPContext : DbContext
  {
    public DbSet<Customer> Customers { get; set; }

    public CPContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Customer>().HasKey(e => e.EntityId);

      OnModelSeeding(builder);
    }

    private static void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Customer>().HasData(new[]
      {
        new Customer() { EntityId = 1, Name = "Abdul-Rauf Yakubu" },
        new Customer() { EntityId = 2, Name = "Daniel Henderson" },
        new Customer() { EntityId = 3, Name = "Stanhope Nwosu" },
        new Customer() { EntityId = 4, Name = "Fred Belotte" },
        new Customer() { EntityId = 5, Name = "Azhya Knox" },
      });
    }
  }
}