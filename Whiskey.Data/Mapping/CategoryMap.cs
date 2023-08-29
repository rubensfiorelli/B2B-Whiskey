using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Mapping
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder
               .HasKey(i => i.Id);

            builder
                .Property(t => t.Title)
                .HasMaxLength(30)
                .IsRequired();

            builder
               .Property(t => t.Description)
               .HasMaxLength(100)
               .IsRequired();
        }
    }
}
