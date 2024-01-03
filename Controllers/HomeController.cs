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

    [Route(template: "", Name = "home.index")]
    public IActionResult Index()
    { 
        return View();
    }

    [Route(template: "About/", Name = "home.about")]
    public IActionResult About()
    {
        return View();
    }

    [Route(template: "Contact/", Name = "home.contact")]
    public IActionResult Contact()
    {
        return View();
    }

    [Route(template: "Pricing/", Name = "home.pricing")]
    public IActionResult Pricing()
    {
        return View();
    }

    [Route(template: "Privacy/", Name = "home.privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [Route(template: "Team/", Name = "home.team")]
    public IActionResult Team()
    {
        return View();
    }


    [Route(template: "Testimonial/", Name = "home.testimonial")]
    public IActionResult Testimonial()
    {
        return View();
    }



    [Route(template: "FAQ/", Name = "home.faq")]
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
