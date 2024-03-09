using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TravelNest.Models;

namespace TravelNest.Controllers;

public class HomeController : Controller
{


    public IActionResult Index()
    {
        
        return View();
    }

}
