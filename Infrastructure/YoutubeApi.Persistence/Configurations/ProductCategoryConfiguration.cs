using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using YoutubeApi.Domain.Entities;

namespace YoutubeApi.Persistence.Configurations
{

    public class ProductCategoryConfiguration : IEntityTypeConfiguration<ProductCategory>
    {
        public void Configure(EntityTypeBuilder<ProductCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId, x.CategoryId });

            builder.HasOne(x => x.Product)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(x => x.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(c => c.Category)
                .WithMany(pc => pc.ProductCategories)
                .HasForeignKey(c => c.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
