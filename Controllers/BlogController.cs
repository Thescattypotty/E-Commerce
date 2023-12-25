using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers;

public class BlogController : Controller
{
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        ViewBag.BackgroundImage2 = Url.Content("~/images/bg-2.jpg");
        return View();
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}