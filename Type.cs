using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Project.Net.Models
{
    public class MyType
    {
       public int Id { get; set; }
       [Required(ErrorMessage = "Name is required")]
       public string Name { get; set; }
       [Required(ErrorMessage = "Category is required")]
       public string Category { get; set; }

       public List<MyType> Types { get; set; }
    }
    public class MyTypeViewModel
    {
      public List<MyType> Types { get; set; }
    }
}