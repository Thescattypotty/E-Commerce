using System.ComponentModel.DataAnnotations.Schema;

namespace E_Commerce.Models.Domain;

public class Categorie
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? PageTitle { get; set; }

    public string? Description { get; set; }
    public byte[]? Image { get; set; }
    public DateTime? CreatedAt { get; set; }

    public ICollection<Product>? Products { get; set; }

    [NotMapped]
    public string? ImageBase64
    {
        get => Image != null ? Convert.ToBase64String(Image) : string.Empty;
    }
}