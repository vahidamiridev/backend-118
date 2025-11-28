using backend_118.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_118.Infrastructure.Data.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.Id);
        builder.Property(a => a.Detail).IsRequired().HasMaxLength(500);
        builder.HasOne(p => p.Contact)
            .WithMany(p => p.Addresses)
            .HasForeignKey(p => p.ContactId);

    }
}