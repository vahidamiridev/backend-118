using backend_118.Domain.Enums;

namespace backend_118.Domain.Entities;

public class PhoneNumber : BaseEntity
{
    public string Value { get; set; } = string.Empty;
    public NumberType Type { get; set; }
    public Guid ContactId { get; set; }
    public Contact Contact { get; set; } = null!;
}