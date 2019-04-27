using WolfStore.Api.Data.Entities;
using WolfStore.Api.Repositories;
using GraphQL.DataLoader;
using GraphQL.Types;

namespace WolfStore.Api.GraphQL.Types
{
  public class ProductType : ObjectGraphType<Product>
  {
    public ProductType()
    {
      Field(t => t.Id);
      Field(t => t.Name);
      Field(t => t.Description);
    }
  }
}