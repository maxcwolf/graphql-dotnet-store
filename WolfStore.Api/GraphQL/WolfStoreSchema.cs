using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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