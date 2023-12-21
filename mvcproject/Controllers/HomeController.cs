using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcproject.Models;
using HR;

namespace mvcproject.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult ProductDetails(){

        Product p1=new Product();
        p1.id=1;
        p1.Name="Chocolate";
        p1.Quantity=19;
        ViewData["Product"]=p1;

    
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
