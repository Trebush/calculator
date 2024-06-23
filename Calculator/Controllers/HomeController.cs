using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Calculator.Models;

namespace Calculator.Controllers;

public class HomeController : Controller{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    public IActionResult Index(){
        return View();
    }

    public IActionResult Privacy(){
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel{ RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpPost]
    public ActionResult Index(int a, int b, string operation)
    {
        try
        {
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.Operation = operation;

            switch (operation)
            {
                case "add":
                    ViewBag.Result = a + b;
                    break;
                case "subtraction":
                    ViewBag.Result = a - b;
                    break;
                case "multiplication":
                    ViewBag.Result = a * b;
                    break;
                case "division":
                    if (b != 0)
                    {
                        ViewBag.Result = a / (double)b; // Cast to double for division
                    }
                    else
                    {
                        ViewBag.Result = "Cannot divide by zero";
                    }
                    break;
                default:
                    ViewBag.Result = "Invalid operation";
                    break;
            }

            return View();
        }
        catch (Exception ex)
        {
            // Log the exception (use any logging framework or simply write to a log file)
            System.Diagnostics.Debug.WriteLine(ex.Message);
            // Optionally, set a ViewBag property to show an error message in the view
            ViewBag.Error = "An error occurred while processing your request.";
            return View("Error"); // Ensure you have an Error view to show a friendly error message
        }
        return View();
    }
}