using backend_118.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_118.Infrastructure.Data.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.FirstName).IsRequired().HasMaxLength(100);
        builder.Property(c => c.LastName).IsRequired().HasMaxLength(100);

        builder.HasMany(c => c.Addresses)
            .WithOne(a => a.Contact)
            .HasForeignKey(a => a.ContactId);

        builder.HasMany(c => c.PhoneNumbers)
            .WithOne(p => p.Contact)
            .HasForeignKey(p => p.ContactId);
    }
}