using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models.Domain;

public class Product
{
    public Guid Id {get ; set;}
    public string? Name {get ; set;}
    public string? PageTitle {get ; set;}
    public string? content {get ; set;}
    public string? ShortDescription {get ; set;}
    public byte[]? Image {get ; set;}
    public double? Price {get ; set;}
    public double? SellPrice {get ; set;}
    public DateTime? PublishedAt {get ; set;}
    public bool? isVisible {get ; set;}
    public Categorie? Categorie {get ; set;}

    
    [NotMapped]
    public string? ImageBase64
    {
        get => Image != null ? Convert.ToBase64String(Image) : string.Empty;
    }

}