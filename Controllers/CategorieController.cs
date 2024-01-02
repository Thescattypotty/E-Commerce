

using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers;

[Route("/categories")]
public class CategorieController : Controller
{
    private readonly ILogger<CategorieController> _logger;

    public CategorieController(ILogger<CategorieController> logger)
    {
        _logger = logger;
    }

    [Route(template: "", Name = "categories.index")]
    public IActionResult Index()
    {
        return View();
    }

    [Route(template: "error/", Name ="categories.error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}