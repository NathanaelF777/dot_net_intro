using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using dot_net_intro.Models;

namespace dot_net_intro.Controllers;

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

    public IActionResult Expenses()
    {
        return View();
    }

    public IActionResult CreateEditExpense()
    {
        return View();
    }

    public IActionResult CreateEditExpenseForm(Expense model)
    {
        Console.WriteLine($"Id is {model.Id}, Value is {model.Value}, Description is {model.Description}");
        return RedirectToAction("Index");
        
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
