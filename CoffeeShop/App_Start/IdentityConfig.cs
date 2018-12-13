using CoffeeShop.Data;
using CoffeeShop.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security.Cookies;

namespace CoffeeShop
{
    public class IdentityConfig
    {
        public void Configuration(IAppBuilder app)
        {
            const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CoffeeShopDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            app.CreatePerOwinContext(() => new AppUserDbContext(connectionString));

            app.CreatePerOwinContext<UserStore<AppUser>>((options, context) =>
                new UserStore<AppUser>(context.Get<AppUserDbContext>()));

            app.CreatePerOwinContext<UserManager<AppUser>>(
                (options, context) => new UserManager<AppUser>(context.Get<UserStore<AppUser>>()));

            app.UseCookieAuthentication(new CookieAuthenticationOptions
                {
                    AuthenticationType = DefaultAuthenticationTypes.ApplicationCookie,
                    LoginPath = new PathString("/Identity/Login"),
                });
        }
    }
}