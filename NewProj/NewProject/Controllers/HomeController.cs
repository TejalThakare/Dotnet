using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NewProject.Models;
using HR;

namespace NewProject.Controllers;

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

    public IActionResult Privacy()
    {
        return View();
    }
        public IActionResult EmployeeDetails()
    {
        Employee p1=new Employee();
        p1.id=1;
        p1.Name="Chocolate";
        p1.Quantity=19;
        ViewData["Product"]=p1;

       
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
