using backend_118.Domain.Dtos;
using backend_118.Domain.Entities;
using backend_118.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

namespace backend_118.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ContactController : ControllerBase
{
    private readonly AddressBookContext dbContext;

    public ContactController(AddressBookContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpPost]
    public ActionResult<ContactDto> Post([FromBody] CreateContactDto createContactDto)
    {
        var contact = new Contact
        {
            FirstName = createContactDto.FirstName,
            LastName = createContactDto.LastName,
            Addresses = createContactDto.Addresses.Select(p => new Address
            {
                Detail = p.Detail
            }).ToList(),
            PhoneNumbers = createContactDto.PhoneNumbers.Select(p => new PhoneNumber
            {
                Value = p.Value,
                Type = p.Type
            }).ToList()
        };
        dbContext.Contacts.Add(contact);
        dbContext.SaveChanges();
        return Ok(MapToDto(contact));

    }

    private ContactDto MapToDto(Contact contact)
    {
        return new ContactDto
        {
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Addresses = contact.Addresses.Select(a => new CreateAddressDto
            {
                Detail = a.Detail
            }).ToList(),
            PhoneNumbers = contact.PhoneNumbers.Select(p => new CreatePhoneNumberDto
            {
                Value = p.Value,
                Type = p.Type
            }).ToList()
        };
    }
}
