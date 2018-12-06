using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Results(User user)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();

            if (user.FirstName != null)
            {
                ORM.Users.Add(user);
                ORM.SaveChanges();
            }

            return View(user);
        }

        public ActionResult Users()
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
            ViewBag.UserList = ORM.Users.ToList();

            return View();
        }
    }
}