using E_Commerce.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace E_Commerce.Controllers;

[Route("/Cart")]
public class CartController : Controller
{
    private readonly ILogger<CartController> _logger;
    private readonly ECommerceDbContext _context;

    public CartController(ECommerceDbContext context , ILogger<CartController> logger)
    {
        _logger = logger ; 
        _context = context;
    }

    [Route(template: "", Name = "cart.index")]
    public async Task<IActionResult> Index()
    {
        if(_context.Carts == null)
        {
            Problem("Entity set 'ECommerceDbContext.Carts'  is null.");
        }
        var carts = await _context.Carts
            .ToListAsync();
        if(carts == null)
        {
            Problem("Entity set 'ECommerceDbContext.Carts'  is null.");
        }

        return View(carts);
    }

    [Route(template: "error/", Name ="cart.error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}