using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Project.Net.Data;
using Project.Net.Models;
using Project.Net.ViewModels;
using ProductViewModel = Project.Net.ViewModels.ProductViewModel;



namespace Project.Net.Controllers
{
     [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        [Route("Product")]
        [HttpGet ("Product")]
      public IActionResult Product()
        {
            // Retrieve all products from the database
            var products = _context.Products.ToList();
            // Return the view with the view model
            return View(products);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            // Display the form to create a new product
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                // Add the new product to the database
                _context.Products.Add(product);
                _context.SaveChanges();

                // Redirect to the product list
                return RedirectToAction(nameof(Product));
            }

            // If model state is not valid, return the view with validation errors
            return View(product);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            // Retrieve the product to edit from the database
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            // Display the form to edit the product
            return View(product);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                // Update the product in the database
                _context.Entry(product).State = EntityState.Modified;
                _context.SaveChanges();

                // Redirect to the product list
                return RedirectToAction(nameof(Product));
            }

            // If model state is not valid, return the view with validation errors
            return View(product);
        }

        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
            // Retrieve the product to delete from the database
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            // Delete the product from the database
            _context.Products.Remove(product);
            _context.SaveChanges();

            // Redirect to the product list
            return RedirectToAction(nameof(Product));
        }


    
 
 //migrations histroy
public class MigrationController : Controller
{
    private readonly AppDbContext _context;

    public MigrationController(AppDbContext context)
    {
        _context = context;
    }
    [HttpGet]
    public IActionResult Index()
    {
        var migrations = _context.Menus.ToList(); // Assuming MigrationsHistory is your DbSet for migration history
        return View(migrations);
    }
}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
       [Route("error")]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }

    internal class GetEnumeratorAttribute : Attribute
    {
    }
}
