using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Project.Net.Models;

namespace Project.Net.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _context;

    public HomeController(ILogger<HomeController> context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Contact()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
       
       [HttpGet("Login")]
        public IActionResult Login(LoginViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index","Home"); 
            }
            return View(model);
        }

        //search bar
    [HttpGet("Search")]
        public IActionResult Search()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Search(string query)
    {
        // Perform search operation using the query parameter
        // Return the search results view or perform other operations
        // For simplicity, we'll just return a view with the search query
        if (IsValidSearchQuery(query))
        {

            return View("SearchResults", query);
        }
        else
        {
            ViewBag.SearchError = "Invalid search query.";
            return View("Search");
        }
    }

    private bool IsValidSearchQuery(string query)
    {
       // throw new NotImplementedException();
        return !string.IsNullOrEmpty(query);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
