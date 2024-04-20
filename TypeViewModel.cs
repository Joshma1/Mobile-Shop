using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Project.Net.Models;

namespace Project.Net.ViewModels
{
    public class MyTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }

        
        public List<MyType> Types { get; set; }
    }
}