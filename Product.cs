using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;



namespace Project.Net.Models
{
    public class Product
{

    public int Id { get; set; }
    [Required(ErrorMessage = "Name is required")]
    public string Name { get; set; }
    [Required(ErrorMessage = "Category is required")]
    public string Category { get; set; }
     [Required(ErrorMessage = "Price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
    public double Price { get; set; }
    [Required(ErrorMessage = "Description is required")]
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public List<Product> Products { get; set; }
    }
        public class ProductViewModel
    {
        // Property to hold a list of products
        public  List<Product> Products { get; set; }
    }
}
