using System;
using WolfStore.Api.Data;
using WolfStore.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using GraphQL;
using WolfStore.Api.GraphQL;
using GraphQL.Server;
using GraphQL.Server.Ui.Playground;
using ProductType = WolfStore.Api.GraphQL.Types.ProductType;

namespace WolfStore.Api
{
  public class Startup
  {
    private readonly IConfiguration _config;

    public Startup(IConfiguration config)
    {
      _config = config;
    }

    public void ConfigureServices(IServiceCollection services)
    {
      services.AddEntityFrameworkMySql();
      services.AddDbContext<WolfStoreDbContext>(
          options => options.UseMySql("server=localhost;port=3306;database=db;user=root;password=Cheesy!2321",
            mySqlOptions =>
                    {
                      mySqlOptions.ServerVersion(new Version(8, 0, 15), ServerType.MySql); // replace with your Server Version and Type
                    }));
      // Must be Scoped since cannot consume scoped service as a singleton
      services.AddScoped<ProductRepository>();

      // Setting up GraphQL to get the Query instance. When Something asks for the IDResolver, it responds with an instance of FuncDepResolver
      services.AddScoped<IDependencyResolver>(s => new FuncDependencyResolver(s.GetRequiredService));
      // Add schema
      services.AddScoped<WolfStoreSchema>();

      services.AddGraphQL(o => { o.ExposeExceptions = true; })
        .AddGraphTypes(ServiceLifetime.Scoped)
        .AddDataLoader();
    }

    public void Configure(IApplicationBuilder app, WolfStoreDbContext dbContext)
    {
      app.UseGraphQL<WolfStoreSchema>();
      app.UseGraphQLPlayground(new GraphQLPlaygroundOptions());
      dbContext.Seed();
    }
  }
}