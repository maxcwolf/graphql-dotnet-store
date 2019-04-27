using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WolfStore.Api.Data.Entities;

namespace WolfStore.Api.Data
{
  public static class InitialData
  {
    public static void Seed(this WolfStoreDbContext dbContext)
    {
      if (dbContext.Products.Any() == false)
      {
        dbContext.Products.Add(new Product
        {
          Name = "Wolf Stuffed Animal",
          Description = "Cute little wolf.",
          Price = 25.5m,
          Rating = 5,
          Type = ProductType.Toys,
          Stock = 20,
          PhotoFileName = "img.jpg",
          IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
        });

        dbContext.Products.Add(new Product
        {
          Name = "Wolfman Action Figure",
          Description = "High quality Wolfman action figure.",
          Price = 50.9m,
          Rating = 5,
          Type = ProductType.Toys,
          Stock = 20,
          PhotoFileName = "img.jpg",
          IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
        });

        dbContext.Products.Add(new Product
        {
          Name = "Glow in the Dark Wolf Tee",
          Description = "Badass glow in the dark, neon wolf T-shirt",
          Price = 199.99m,
          Rating = 5,
          Type = ProductType.Clothes,
          Stock = 10,
          PhotoFileName = "img.jpg",
          IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
        });

        dbContext.Products.Add(new Product
        {
          Name = "Wolf Furry Suit",
          Description = "Are you a Furry and want to be a Wolf? This is for you!",
          Price = 500.99m,
          Rating = 5,
          Type = ProductType.Clothes,
          Stock = 10,
          PhotoFileName = "img.jpg",
          IntroducedAt = DateTimeOffset.Now.AddMonths(-1)
        });

        dbContext.SaveChanges();
      }
    }
  }
}
