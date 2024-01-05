

using E_Commerce.Data;
using E_Commerce.Models.Domain;
using E_Commerce.Models.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Models;


public static class SeedData
{
    public static void InitializeDomain(IServiceProvider serviceProvider)
    {
        using (var context = new ECommerceDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<ECommerceDbContext>>()
        ))
        {
            if (context.Products.Any() || context.Categories.Any())
            {
                return;
            }
            context.Categories.AddRange(
                new Categorie
                {
                    Name = "Extra Bottle",
                    PageTitle = "Extra-Bottle",
                    CreatedAt = new DateTime(),
                    Description = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    Image = ReadImageAsByteArray("images/product/pdm-1.jpg")

                },
                new Categorie
                {
                    Name = "Big Bottle",
                    PageTitle = "Big-Bottle",
                    CreatedAt = new DateTime(),
                    Description = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    Image = ReadImageAsByteArray("images/product/pdm-2.jpg")
                }
            );
            context.Products.AddRange(
                new Product
                {
                    Name = "Mineral water small bottle",
                    PageTitle = "Mineral-water-small-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-1.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water big bottle",
                    PageTitle = "Mineral-water-big-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-2.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water bold bottle",
                    PageTitle = "Mineral-water-bold-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-3.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water fit bottle",
                    PageTitle = "Mineral-water-fit-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-4.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water extra bottle",
                    PageTitle = "Mineral-water-extra-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-1.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water mini bottle",
                    PageTitle = "Mineral-water-mini-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-2.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water bold bottle",
                    PageTitle = "Mineral-water-bold-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-3.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                },
                new Product
                {
                    Name = "Mineral water undo bottle",
                    PageTitle = "Mineral-water-undo-bottle",
                    content = "Lorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom Lorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum UpsomLorum Upsom",
                    ShortDescription = "Mauris sed massa eu nulla mollis vehicula quis id tortor.",
                    Image = ReadImageAsByteArray("images/product/p-4.jpg"),
                    PublishedAt = new DateTime(),
                    isVisible = true,
                    Price = 215,
                    SellPrice = 259
                }

            );
            context.SaveChanges();
        }
    }


    public static byte[] ReadImageAsByteArray(string imagePath)
    {
        try
        {
            // Direct path to the images directory
            string finalPath = Path.Combine("/home/senshi/Desktop/E-Commerce/wwwroot", imagePath);

            Console.WriteLine($"Attempting to read image from path: {finalPath}");

            if (File.Exists(finalPath))
            {
                byte[] imageBytes = File.ReadAllBytes(finalPath);
                return imageBytes;
            }
            else
            {
                Console.WriteLine($"File not found at path: {finalPath}");
                return null;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading image: {e.Message}");
            return null;
        }
    }
}