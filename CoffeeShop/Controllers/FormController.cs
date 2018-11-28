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
            return View(user);
        }
    }
}