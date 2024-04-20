using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Project.Net.Models
{
    public class Menu
    {
       public int Id { get; set; } // Id for the menu (optional if you have only one menu)
       public string Name { get; set; }
       public string Category { get; set; }
       public string Url { get; set; }
       public int ParentId { get; set; }


       public List<MenuItem> Items { get; set; } // List of menu items

        // Constructor to initialize the list of menu items
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Menu()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
           Items = new List<MenuItem>();
       }
    }
}