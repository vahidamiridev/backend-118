namespace backend_118.Domain.Dtos;


public class ContactDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<CreateAddressDto> Addresses { get; set; } = new();
    public List<CreatePhoneNumberDto> PhoneNumbers { get; set; } = new();
}