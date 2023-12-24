using E_Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data;
public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Product> Products {get; set;}
    public DbSet<Categorie> Categories {get; set;}
}