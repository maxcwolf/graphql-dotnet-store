using System.Collections.Generic;
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

    public IEnumerable<Product> GetAll()
    {
      return _dbContext.Products;
    }
  }
}
