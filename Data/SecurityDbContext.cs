using E_Commerce.Models.Security;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using E_Commerce.Models;
using System.Linq;

namespace E_Commerce.Data;
public class SecurityDbContext : IdentityDbContext<User, IdentityRole<Guid>, Guid>
{
    public SecurityDbContext(DbContextOptions<SecurityDbContext> options)
    : base(options)
    {

    }

    public static async Task SeedData(UserManager<User> userManager)
    {
        if (!userManager.Users.Any())
        {
            var user = new User
            {
                FirstName = "Yahya",
                LastName = "Bennis",
                City = "Mohammedia",
                Adress = "Cite 9juillet , B3 , App8",
                ProfileImage = ReadImageAsByteArrayt("images/client/c-1.jpg"),
                Birthday = new DateTime(),
                UserName = "bnsyahya123@gmail.com",
                Email = "bnsyahya123@gmail.com",
                EmailConfirmed = true,
            };
            await userManager.CreateAsync(user, "Mtklsduftuv972@");
        }
    }
    public static byte[] ReadImageAsByteArrayt(string imagePath)
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