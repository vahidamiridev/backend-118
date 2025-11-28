using backend_118.Domain.Entities;
using backend_118.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace backend_118.Infrastructure.Data;

public class AddressBookContext : DbContext
{
    private readonly IConfiguration _configuration;
    public AddressBookContext(IConfiguration config)
    {
        this._configuration = config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var conectionstring = _configuration.GetConnectionString("AddressBookConnectionString");
        optionsBuilder.UseSqlServer(conectionstring);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new ContactConfiguration());
        modelBuilder.ApplyConfiguration(new AddressConfiguration());
        modelBuilder.ApplyConfiguration(new PhoneNumberConfiguration());
    }

    public DbSet<Contact> Contacts { get; set; }
    public DbSet<PhoneNumber> PhoneNumbers { get; set; }
    public DbSet<Address> Addresses { get; set; }
}