using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Project.Net.Models
{
    public class LoginViewModel
    {
       [Required(ErrorMessage = "Username is required")]
        public double Username { get; set; }

        [Required(ErrorMessage = "Password is required")]
        public  double Password { get; set; }
    }
}