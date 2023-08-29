using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Whiskey.Domain.Entities;

namespace Whiskey.Data.Mapping
{
    public class CostumerMap : IEntityTypeConfiguration<Costumer>
    {
        public void Configure(EntityTypeBuilder<Costumer> builder)
        {
            builder
               .HasKey(i => i.Id);

            builder
                .Property(n => n.FirstName)
                .HasMaxLength(20)
                .IsRequired();

            builder
              .Property(n => n.LastName)
              .HasMaxLength(50)
              .IsRequired();

            builder
              .Property(n => n.Email)
              .HasMaxLength(50)
              .IsRequired();

            builder
              .HasIndex(i => i.Email)
              .IsUnique();

            builder
             .Property(n => n.WhatsApp)
             .HasMaxLength(12)
             .IsRequired();

            builder
                .OwnsOne(d => d.DeliveryAddress);

            builder
                .HasMany(o => o.Orders)
                .WithOne()
                .HasForeignKey(fk => fk.CustomerId);

        }
    }
}
