using E_Commerce.Data;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models.Domain;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace E_Commerce.Controllers;

[Route(template: "Products/")]
public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;
    private readonly ECommerceDbContext _context;
    public ProductController(ECommerceDbContext context,ILogger<ProductController> logger)
    {
        _context = context;
        _logger = logger;
    }

    //GET Method : 
    [Route(template: "", Name ="products.index")]
    public async Task<IActionResult> Index()
    {
        if(_context.Products == null)
        {
            Problem("Entity set 'ECommerceDbContext.Products'  is null.");
        }
        var Products = await _context.Products
            .Where(m=> m.isVisible == true)
            .ToListAsync();

        if(Products == null)
        {
            Problem("Entity set 'ECommerceDbContext.Products'  is null.");
        }

        return View(Products);
    }

    [Route(template: "{id}/")]
    public async Task<IActionResult> Details(Guid? id)
    {
        if (id == null || _context.Products == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .FirstOrDefaultAsync(m => m.Id == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
    }

    [Route(template: "error/", Name ="products.error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}