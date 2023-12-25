

using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers;

public class CategorieController : Controller
{
    private readonly ILogger<CategorieController> _logger;

    public CategorieController(ILogger<CategorieController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}