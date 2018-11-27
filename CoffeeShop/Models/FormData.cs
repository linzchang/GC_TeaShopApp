using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GC_CoffeeShop.Models
{
    public class FormData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string FavoriteDrink { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}