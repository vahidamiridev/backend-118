using backend_118.Domain.Enums;

namespace backend_118.Domain.Dtos;


public class CreatePhoneNumberDto
{
    public string Value { get; set; } = string.Empty;
    public NumberType Type { get; set; } 
    public Guid? ContactId { get; set; } 

}