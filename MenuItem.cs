using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Net.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; }
        [Required(ErrorMessage = "Url is required")]
        public string Url { get; set; }
        public int ParentId { get; set; } 
    }
}