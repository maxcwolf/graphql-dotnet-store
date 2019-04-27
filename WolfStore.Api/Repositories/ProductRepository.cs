using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WolfStore.Api.Data;
using WolfStore.Api.Data.Entities;

namespace WolfStore.Api.Repositories
{
  public class ProductRepository
  {
    private readonly WolfStoreDbContext _dbContext;

    public ProductRepository(WolfStoreDbContext dbContext)
    {
      _dbContext = dbContext;
    }

    public async Task<IEnumerable<Product>> GetAll()
    {
      return await _dbContext.Products.ToListAsync();
    }

    public async Task<Product> GetOne(int id)
    {
      return await _dbContext.Products.SingleOrDefaultAsync(p => p.Id == id);
    }
  }
}
