namespace E_Commerce.Models.Domain;

public class Product
{
    public Guid Id {get ; set;}
    public string? Name {get ; set;}
    public string? PageTitle {get ; set;}
    public string? content {get ; set;}
    public string? ShortDescription {get ; set;}
    public string? FeaturedImageUrl {get ; set;}
    public string? UrlHandle {get ; set;}
    public DateTime? PublishedAt {get ; set;}
    public bool? isVisible {get ; set;}
    public ICollection<Categorie>? Categories {get ; set;}

}