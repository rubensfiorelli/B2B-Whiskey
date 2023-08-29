using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Mapping
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .Property(t => t.Title)
                .HasMaxLength(60)
                .IsRequired();

            builder
               .Property(t => t.Description)
               .HasMaxLength(300)
               .IsRequired();

            builder
                .HasOne(c => c.Category)
                .WithMany(c => c.Products)
                .IsRequired()
                .HasForeignKey(c => c.CategoryId);
        }
    }
}
