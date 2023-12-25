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

    [Route(template: "", Name = "index")]
    public IActionResult Index()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/bg-1.jpg");
        ViewBag.BackgroundImage2 = Url.Content("~/images/bg-2.jpg");
        return View();
    }

    [Route(template: "About/", Name = "about")]
    public IActionResult About()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        ViewBag.BackgroundImage2 = Url.Content("~/images/bg-2.jpg");

        return View();
    }

    [Route(template: "Contact/", Name = "contact")]
    public IActionResult Contact()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        ViewBag.BackgroundImage2 = Url.Content("~/images/bg-2.jpg");
        return View();
    }

    [Route(template: "Pricing/", Name = "pricing")]
    public IActionResult Pricing()
    {
        ViewBag.BackgroundImage = Url.Content("~/images/page-banner.jpg");
        ViewBag.BackgroundImage2 = Url.Content("~/images/bg-2.jpg");
        return View();
    }

    [Route(template: "Privacy/", Name = "privacy")]
    public IActionResult Privacy()
    {
        return View();
    }

    [Route(template: "Team/", Name = "team")]
    public IActionResult Team()
    {
        return View();
    }


    [Route(template: "Testimonial/", Name = "testimonial")]
    public IActionResult Testimonial()
    {
        return View();
    }



    [Route(template: "FAQ/", Name = "faq")]
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
