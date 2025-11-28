using backend_118.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace backend_118.Infrastructure.Data.Configurations;

public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
{
    public void Configure(EntityTypeBuilder<PhoneNumber> builder)
    {
        builder.HasKey(p => p.Id);
        builder.Property(v => v.Value).IsRequired().HasMaxLength(15);
        builder.HasOne(p => p.Contact).WithMany(p => p.PhoneNumbers)
        .HasForeignKey(p => p.ContactId);
    }
}