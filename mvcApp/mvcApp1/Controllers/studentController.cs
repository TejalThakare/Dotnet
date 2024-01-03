namespace mvcApp1.Controllers;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvcApp1.Models;
using BLL;
using BOL;


public class studentController : Controller
{
    private readonly ILogger<studentController> _logger;

    public studentController(ILogger<studentController> logger)
    {
        _logger = logger;
    }

    public IActionResult student()
    {
        List<student> s1 = studentService.getAllData();
        ViewData["student"] = s1;
        return View();
    }

    
    [HttpGet]
    public IActionResult insertstudent()
    {
        return View();
    }

    [HttpPost]
    public IActionResult insertstudent(int ID,string NameFirst,string NameLast,string Dob,string EmailId)
    {
        //Console.WriteLine(Username+Password);

        studentService.InsertData(ID,NameFirst,NameLast,Dob, EmailId);

        return View();
    }

    public IActionResult  update()
    {
        return View();
    }

    [HttpPost]
    public IActionResult update(int ID,string NameFirst,string NameLast,string Dob,string EmailId)
    {
        //Console.WriteLine(Username+Password);

        studentService.updatestudent(ID,NameFirst,NameLast,Dob, EmailId);

        return View();
    }


public IActionResult delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult delete(int ID)
    {
        //Console.WriteLine(Username+Password);

        studentService.deletestudent(ID);

        return View();
    }


}
