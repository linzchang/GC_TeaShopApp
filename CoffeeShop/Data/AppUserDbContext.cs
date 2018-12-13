using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;

namespace CoffeeShop.Data
{
    public class AppUserDbContext : IdentityDbContext<AppUser>
    {
        public AppUserDbContext(string connectionString): base(connectionString) { }
    }
}