using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{
    internal class ProductConfiguration
    {
        Faker faker = new("tr");

        public void Configure(EntityTypeBuilder<Product> builder)
        {
            Product product1 = new()
            {
                Id = 1,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 1,
                Discount = faker.Random.Decimal(1, 10),
                Price = faker.Random.Decimal(10, 1000),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
            Product product2 = new()
            {
                Id = 2,
                Title = faker.Commerce.ProductName(),
                Description = faker.Commerce.ProductDescription(),
                BrandId = 3,
                Discount = faker.Random.Decimal(1, 10),
                Price = faker.Random.Decimal(10, 1000),
                CreatedDate = DateTime.Now,
                IsDeleted = false
            };
          
            builder.HasData(product1, product2);
        }
    }
}
