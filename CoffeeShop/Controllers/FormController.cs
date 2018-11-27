using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GC_CoffeeShop.Controllers
{
    public class FormController : Controller
    {
        // GET: Form
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult FormOne(string firstName, string lastName, string address, string email,
            int phoneNumber, string favoriteDrink, string username, string password)
        {
            return RedirectToAction("ActionName");
        }
    }
}