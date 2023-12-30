using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using Emp;

namespace MvcProject.Controllers;

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

    public IActionResult Employee()
    {
        Employee e1=new Employee();
        e1.Id=1;
        e1.Name="raj Vasu";
        e1.Role="Software Engineer";
        e1.Salary=120000;
        ViewData["Employee"]=e1;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
