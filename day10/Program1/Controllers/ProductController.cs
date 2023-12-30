using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Program1.Models;
using BusinessObjectLayer;
using BusinessLogicLayer;

namespace Program1.Controllers;

public class ProductController : Controller
{
    private readonly ILogger<ProductController> _logger;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cataloge mgr=new Cataloge();
        List<Product> products=mgr.GetAllProduct();
        ViewData["allProducts"]=products;
        return View();

    }

    

   
}
