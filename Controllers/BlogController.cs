using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers;

[Route(template: "Blogs/")]
public class BlogController : Controller
{
    private readonly ILogger<BlogController> _logger;

    public BlogController(ILogger<BlogController> logger)
    {
        _logger = logger;
    }

    [Route(template: "", Name = "blogs.index")]
    public IActionResult Index()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        ViewBag.BackgroundImage2 = Url.Content("~/images/bg-2.jpg");
        return View();
    }

    [Route(template: "error/", Name = "blogs.error")]
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new Models.ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}