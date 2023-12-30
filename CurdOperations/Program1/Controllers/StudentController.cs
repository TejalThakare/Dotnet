namespace Program1.Controllers;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BOL;
using BLL;
using System.Collections.Generic;       




public class StudentController : Controller
{
    private readonly ILogger<StudentController> _logger;

    public StudentController(ILogger<StudentController> logger)
    {
        _logger = logger;
    }

    public IActionResult Student()
    {
        // StudentManager mrg=new StudentManager();
        List<Student> L1=StudentManager.GetAllStudent();
        ViewData["Student"]=L1;
        return View();
    }

    

  
}
