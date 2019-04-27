using WolfStore.Api.GraphQL.Types;
using WolfStore.Api.Repositories;
using GraphQL.Types;

namespace WolfStore.Api.GraphQL
{
  public class WolfStoreQuery : ObjectGraphType
  {
    public WolfStoreQuery(ProductRepository productRepository)
    {
      Field<ListGraphType<ProductType>>(
        "products",
        resolve: context => productRepository.GetAll()
      );
    }
  }

}