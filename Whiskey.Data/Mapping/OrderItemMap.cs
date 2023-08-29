using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Mapping
{
    public class OrderItemMap : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder
                 .HasKey(x => x.Id);

            builder
                .Property(t => t.Title)
                .HasMaxLength(60)
                .IsRequired();
        }
    }
}
