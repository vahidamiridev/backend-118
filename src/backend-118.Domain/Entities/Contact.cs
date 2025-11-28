namespace backend_118.Domain.Entities;

public class Contact : BaseEntity
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<Address> Addresses { get; set; } = new();
    public List<PhoneNumber> PhoneNumbers { get; set; } = new();
}