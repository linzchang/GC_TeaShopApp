using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeShop.Models
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FavoriteDrink { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public User()
        {
        }

        public User(string firstName, string lastName, string address, string email, string phoneNumber, string favoriteDrink, string username, string password)
        {
            favoriteDrink = FavoriteDrink;
            lastName = LastName;
            address = Address;
            email = Email;
            phoneNumber = PhoneNumber;
            favoriteDrink = FavoriteDrink;
            username = Username;
            password = Password;
        }
    }
}