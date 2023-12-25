using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using E_Commerce.Models;

namespace E_Commerce.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/bg-1.jpg");
        return View();
    }

    public IActionResult About()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        
        return View();
    }

    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Pricing()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        return View();
    }

    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Team()
    {
        return View();
    }
    public IActionResult Testimonial()
    {
        return View();
    }

    public IActionResult FAQ()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
