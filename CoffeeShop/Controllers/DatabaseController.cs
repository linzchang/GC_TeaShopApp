using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult ItemList()
        {
            string userEmail = User.Identity.Name;
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
            ViewBag.UserItems = ORM.Items.Where(x => x.Email == userEmail).ToList();

            return View();
        }
    }
}