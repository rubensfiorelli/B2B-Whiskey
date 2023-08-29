using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Mapping
{
    public class OrderMap : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .Property(t => t.OrderNumber)
                .HasMaxLength(10);

            builder
                .HasIndex(t => t.OrderNumber)
                .IsUnique();

            builder
              .Property(d => d.Description)
              .HasMaxLength(300)
              .IsRequired();

            builder
              .OwnsOne(a => a.DeliveryAddress);


        }
    }
}
