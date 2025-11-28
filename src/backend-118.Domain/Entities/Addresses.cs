namespace backend_118.Domain.Entities;

public class Address : BaseEntity
{
    public string Detail { get; set; } = string.Empty;
    public Guid ContactId { get; set; }
    public Contact Contact { get; set; } = null!;
}