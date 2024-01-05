using E_Commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce.Controllers;

[Route("/categories")]
public class CategorieController : Controller
{
    private readonly ILogger<CategorieController> _logger;
    private readonly ECommerceDbContext _context;

    public CategorieController(ECommerceDbContext context,ILogger<CategorieController> logger)
    {
        _context = context;
        _logger = logger;
    }

    //GET method
    [Route(template: "", Name = "categories.index")]
    public async Task<IActionResult> Index()
    {
        if(_context.Categories == null)
        {
            Problem("Entity set 'ECommerceDbContext.Categories'  is null.");
        }
        var categories = await _context.Categories
            .ToListAsync();
        if(categories == null)
        {
            Problem("Entity set 'ECommerceDbContext.Categories'  is null.");
        }

        return View(categories);
    }

    [Route(template: "error/", Name ="categories.error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}