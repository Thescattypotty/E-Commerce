using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Models.Security;

public class User : IdentityUser<Guid>
{
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public string? Address {get; set;}

    public DateTime? Birthday{get ; set;}
}