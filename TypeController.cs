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
    public class TypeController : Controller
    {
        private readonly AppDbContext _context;

        public TypeController(AppDbContext context)
        {
            _context = context;
        }

        [Route("MyType")]
        [HttpGet("MyType")]
        public IActionResult MyType()
        {
            var types = _context.Types.ToList();
            return View(types);
        }
        [HttpGet("create")]
        public IActionResult Create()
        {
            // Display the form to create a new product
            return View();
        }
                [HttpPost("create")]
        public IActionResult Create(MyType type)
        {
            if (ModelState.IsValid)
            {
                // Add the new product to the database
                _context.Types.Add(type);
                _context.SaveChanges();

                // Redirect to the product list
                return RedirectToAction(nameof(MyType));
            }

            // If model state is not valid, return the view with validation errors
            return View(type);
        }

        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            // Retrieve the product to edit from the database
            var type = _context.Types.Find(id);
            if (type == null)
            {
                return NotFound();
            }

            // Display the form to edit the product
            return View(type);
        }

        [HttpPost("edit/{id}")]
        public IActionResult Edit(int id, MyType type)
        {
            if (id != type.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                // Update the product in the database
                _context.Entry(type).State = EntityState.Modified;
                _context.SaveChanges();

                // Redirect to the product list
                return RedirectToAction(nameof(MyType));
            }

            // If model state is not valid, return the view with validation errors
            return View(type);
        }

                [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
            // Retrieve the product to delete from the database
            var type = _context.Types.Find(id);
            if (type == null)
            {
                return NotFound();
            }

            // Delete the product from the database
            _context.Types.Remove(type);
            _context.SaveChanges();

            // Redirect to the product list
            return RedirectToAction(nameof(MyType));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}