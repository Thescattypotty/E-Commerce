using Microsoft.AspNetCore.Identity;

namespace E_Commerce.Models.Security;

public class User : IdentityUser<Guid>
{
    public string? FirstName {get; set;}
    public string? LastName {get; set;}

    public string? City {get ; set;}
    public string? Adress {get; set;}

    public byte[]? ProfileImage {get ; set;}

    public DateTime? Birthday{get ; set;}
}