using WolfStore.Api.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace WolfStore.Api.Data
{
  public class WolfStoreDbContext : DbContext
  {
    public WolfStoreDbContext(DbContextOptions<WolfStoreDbContext> options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
  }
}
