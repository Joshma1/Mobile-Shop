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
    public class MenuController : Controller
    {
        private readonly AppDbContext _context;

        public MenuController(AppDbContext context)
        {
            _context = context;
        }

        // Action to display all menu items
        [HttpGet("MenuItem")]
        public IActionResult MenuItem()
        {
            var menuItems = _context.Menus.ToList();
            return View(menuItems);
        }

        // Action to display the form for creating a new menu item
        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        // Action to handle the creation of a new menu item
        [HttpPost("create")]
        public IActionResult Create(MenuItem menu)
        {
            if (ModelState.IsValid)
            {
                _context.Menus.Add(menu);
                _context.SaveChanges();
                return RedirectToAction(nameof(MenuItem));
            }
            return View(menu);
        }

        // Action to display the form for editing a menu item
        [HttpGet("edit/{id}")]
        public IActionResult Edit(int id)
        {
            var menu = _context.Menus.Find(id);
            if (menu == null)
            {
                return NotFound();
            }
            return View(menu);
        }

        // Action to handle the editing of a menu item
        [HttpPost("edit/{id}")]
        public IActionResult Edit(int id, MenuItem menu)
        {
            if (id != menu.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                _context.Entry(menu).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction(nameof(MenuItem));
            }

            return View(menu);
        }

        // Action to handle the deletion of a menu item
        [HttpPost("delete/{id}")]
        public IActionResult Delete(int id)
        {
            var menu = _context.Menus.Find(id);
            if (menu == null)
            {
                return NotFound();
            }

            _context.Menus.Remove(menu);
            _context.SaveChanges();
            return RedirectToAction(nameof(MenuItem));
        }

        // Error handling action
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}





// public class MenuController : Controller
// {
//     private readonly AppDbContext _context;

//     public MenuController(AppDbContext context)
//     {
//         _context = context;
//     }

//     [Route("MenuItem")]
//     [HttpGet("MenusItem")]
//     public IActionResult MenuItem()
//     {
//         // Add logic for menu items
//         var menus = _context.Menus.ToList();
//         return View(menus);
//     }
//         [HttpGet("create")]
//         public IActionResult Create()
//         {
//             // Display the form to create a new product
//             return View();
//         }

//         [HttpPost("create")]
//         public IActionResult Create(MenuItem menu)
//         {
//             if (ModelState.IsValid)
//             {
//                 // Add the new product to the database
//                 _context.Menus.Add(menu);
//                 _context.SaveChanges();

//                 // Redirect to the product list
//                 return RedirectToAction(nameof(MenuItem));
//             }

//             // If model state is not valid, return the view with validation errors
//             return View(menu);
//         }

//         [HttpGet("edit/{id}")]
//         public IActionResult Edit(int id)
//         {
//             // Retrieve the product to edit from the database
//             var menu = _context.Menus.Find(id);
//             if (menu == null)
//             {
//                 return NotFound();
//             }

//             // Display the form to edit the product
//             return View(menu);
//         }

//         [HttpPost("edit/{id}")]
//         public IActionResult Edit(int id, MenuItem menu)
//         {
//             if (id != menu.Id)
//             {
//                 return BadRequest();
//             }

//             if (ModelState.IsValid)
//             {
//                 // Update the product in the database
//                 _context.Entry(menu).State = EntityState.Modified;
//                 _context.SaveChanges();

//                 // Redirect to the product list
//                 return RedirectToAction(nameof(MenuItem));
//             }

//             // If model state is not valid, return the view with validation errors
//             return View(menu);
//         }

//         [HttpPost("delete/{id}")]
//         public IActionResult Delete(int id)
//         {
//             // Retrieve the product to delete from the database
//             var menu = _context.Menus.Find(id);
//             if (menu == null)
//             {
//                 return NotFound();
//             }

//             // Delete the product from the database
//             _context.Menus.Remove(menu);
//             _context.SaveChanges();

//             // Redirect to the product list
//             return RedirectToAction(nameof(MenuItem));
//         }
// }