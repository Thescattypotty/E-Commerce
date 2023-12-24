using Microsoft.AspNetCore.Mvc;

namespace E_Commerce.Controllers;

public class AdminController : Controller
{

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
}