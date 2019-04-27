using System;
using WolfStore.Api.Data;
using WolfStore.Api.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;


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
      services.AddSingleton<ProductRepository>();
    }

    public void Configure(IApplicationBuilder app, WolfStoreDbContext dbContext)
    {
      dbContext.Seed();
    }
  }
}