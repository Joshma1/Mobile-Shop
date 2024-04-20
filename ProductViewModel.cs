using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Net.Models;

namespace Project.Net.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
    
    
        public List<Product> Products { get; set; }
    }
}