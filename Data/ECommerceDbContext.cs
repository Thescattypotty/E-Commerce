using E_Commerce.Models.Cart;
using E_Commerce.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Data;
public class ECommerceDbContext : DbContext
{
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products {get; set;}
    public DbSet<Categorie> Categories {get; set;}
    public DbSet<Cart> Carts {get ; set;}
    public DbSet<CartItem> CartItems {get ; set;}
}