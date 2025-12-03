namespace backend_118.Domain.Dtos;


public class CreateAddressDto
{
    public string Detail { get; set; } = string.Empty;
    public Guid? ContactId { get; set; }

}