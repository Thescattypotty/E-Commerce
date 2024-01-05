using System.ComponentModel.DataAnnotations.Schema;
using E_Commerce.Models.Domain;

namespace E_Commerce.Models.Cart;

public class CartItem
{
    public Guid Id{get ; set;}
    public Cart? Cart {get ; set;}
    public Product? Product {get ; set;}
    public int? Quantity {get ; set;}

}