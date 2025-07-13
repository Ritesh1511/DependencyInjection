using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DependencyInjection.Models;
using DependencyInjection.Services;

namespace DependencyInjection.Controllers;

public class HomeController : Controller
{
    public readonly CustomClass _customClass;
    public readonly CustomClass _customClass2;
    private readonly ILogger<HomeController> _logger;


    public HomeController(ILogger<HomeController> logger , CustomClass       customClass , CustomClass customClass2)
    {
        _customClass = customClass;
        _customClass2 = customClass2;
        _logger = logger;
    }


  
    public IActionResult Index()
    {
        _customClass.ChangeValue();
   
        // statement just to print same
      
        var customValue1 = _customClass.publicValue;
        var customValue2 = _customClass2.publicValue;
      
      
      
        ViewData["Value1"] = customValue1;
        ViewData["Value2"] = customValue2;
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
