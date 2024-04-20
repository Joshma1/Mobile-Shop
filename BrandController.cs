using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Project.Net.Data;
using Project.Net.Models;

namespace Project.Net.Controllers
{
    [Route("[controller]")]
    public class BrandController : Controller
    {
        private readonly AppDbContext _context;

        public BrandController(AppDbContext context)
        {
            _context = context;
        }
        
        [Route("Brand")]
        [HttpGet("Brand")]
        public IActionResult Brand()
        {
            var brand = _context.Brands.ToList();
            return View(brand);
        }
        [HttpGet("create")]
        public IActionResult Create()
        {
            // Display the form to create a new product
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(Brand brand)
        {
            if (ModelState.IsValid)
            {
                // Add the new product to the database
                _context.Brands.Add(brand);
                _context.SaveChanges();

                // Redirect to the product list
                return RedirectToAction(nameof(Brand));
            }

            // If model state is not valid, return the view with validation errors
            return View(brand);
        }
        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            // Retrieve the product to edit from the database
            var brand = _context.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }

            // Display the form to edit the product
            return View(brand);
        }
        [HttpPost("edit/{id}")]
        public IActionResult Edit(int id, Brand brand)
        {
            if (id != brand.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                // Update the product in the database
                _context.Entry(brand).State = EntityState.Modified;
                _context.SaveChanges();

                // Redirect to the product list
                return RedirectToAction(nameof(Brand));
            }

            // If model state is not valid, return the view with validation errors
            return View(brand);
        }
        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
            // Retrieve the product to delete from the database
            var brand = _context.Brands.Find(id);
            if (brand == null)
            {
                return NotFound();
            }

            // Delete the product from the database
            _context.Brands.Remove(brand);
            _context.SaveChanges();

            // Redirect to the product list
            return RedirectToAction(nameof(Brand));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}