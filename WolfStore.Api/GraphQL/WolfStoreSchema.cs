using GraphQL;
using GraphQL.Types;

namespace WolfStore.Api.GraphQL
{
  public class WolfStoreSchema : Schema
  {
    public WolfStoreSchema(IDependencyResolver resolver) : base(resolver)
    {
      Query = resolver.Resolve<WolfStoreQuery>();
    }
  }

}