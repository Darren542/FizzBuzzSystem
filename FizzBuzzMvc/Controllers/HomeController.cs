using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FizzBuzzMvc.Models;
using System.Globalization;
using FizzBuzzLibrary;

namespace FizzBuzzMvc.Controllers;

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

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpPost]
    public IActionResult FizzBuzz(int? number)
    {
        var fizzBuzzLogic = new FizzBuzzLogic();
        string? output = fizzBuzzLogic.GetFizzBuzz(number);
        ViewBag.result = output;
        return View("Index");
    }
}
