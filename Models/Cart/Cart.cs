using System.ComponentModel.DataAnnotations.Schema;
using E_Commerce.Models.Security;

namespace E_Commerce.Models.Cart;

public class Cart
{
    public Guid Id{get ; set;}
    public User? User {get ; set;}
    public ICollection<CartItem>? CartItems {get ; set;}
}