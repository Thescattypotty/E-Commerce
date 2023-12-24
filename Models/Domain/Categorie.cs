namespace E_Commerce.Models.Domain;

public class Categorie
{
    public Guid Id {get ; set;}
    public string? Name {get ; set;}
    public ICollection<Product>? Products {get ; set;}

}