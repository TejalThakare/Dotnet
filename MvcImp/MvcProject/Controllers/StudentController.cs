using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcProject.Models;
using std;

namespace MvcProject.Controllers;

public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

   public IActionResult Student()
    {
        Student s1=new Student();
        s1.Id=1;
        s1.Name="sakshi";
        s1.Marks=99;
        ViewData["Student"]=s1;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
