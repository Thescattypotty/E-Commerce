using E_Commerce.Models.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data;
public class SecurityDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public SecurityDbContext(DbContextOptions<SecurityDbContext> options)
    :base(options)
    {

    }
}