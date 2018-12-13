using CoffeeShop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.Owin.Security;

namespace CoffeeShop.Controllers
{
    public class AccountController : Controller
    {
        public UserManager<IdentityUser> userManager => 
            HttpContext.GetOwinContext().Get<UserManager<IdentityUser>>();

        // GET: Identity
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Registration(RegisterModel newUser)
        {
            if (ModelState.IsValid)
            {


                IdentityUser user = new IdentityUser()
                {
                    UserName = newUser.Email,
                    Email = newUser.Email,
                    PhoneNumber =newUser.PhoneNumber,
                };

                var IdentityResult = await userManager.CreateAsync(user, newUser.Password);
                if (IdentityResult.Succeeded)
                {
                    CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
                    User addUser = new User()
                    {
                        FirstName = newUser.FirstName,
                        LastName = newUser.LastName,
                        FavoriteDrink = newUser.FavoriteDrink,
                        Email = newUser.Email,
                        Address = newUser.Address
                    };

                    ORM.Users.Add(addUser);
                    ORM.SaveChanges();
                    return RedirectToAction("Login", newUser);
                }
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel login)
        {
            if (ModelState.IsValid)
            {
                var authenticationManager = HttpContext.GetOwinContext().Authentication;

                IdentityUser user = userManager.Find(login.Email, login.Password);

                if (user != null)
                {
                    var ident = userManager.CreateIdentity(user,
                        DefaultAuthenticationTypes.ApplicationCookie);
                    authenticationManager.SignIn(
                        new AuthenticationProperties { IsPersistent = false }, ident);
                    return RedirectToAction("Index", "Home");
                }
            }

            ModelState.AddModelError("", "Invalid email or password.");
            return View(login);
        }
    }
}