// need to import Microsoft.EntityFrameworkCore
using Microsoft.EntityFrameworkCore;
// this import the Product class created
using API.Entities;

namespace API.Data
{
    public class StoreContext : DbContext
    {
      public StoreContext(DbContextOptions options) : base(options)
      {
      }

      public DbSet<Product> Products { get; set; }
    }
}