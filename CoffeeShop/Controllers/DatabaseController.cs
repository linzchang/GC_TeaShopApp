using CoffeeShop.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoffeeShop.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
        public ActionResult AddItem()
        {
            return View();
        }

        public ActionResult SaveNewItem(Item newItem)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();

            if (newItem != null)
            {
                ORM.Items.Add(newItem);
                ORM.SaveChanges();
            }

            return RedirectToAction("Items", "Home");
        }

        public ActionResult EditItem(int itemID)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
            Item found = ORM.Items.Find(itemID);

            return View(found);
        }

        public ActionResult SaveItemChanges(Item updatedItem)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
            Item oldItem = ORM.Items.Find(updatedItem.ItemID);
            oldItem.ItemName = updatedItem.ItemName;
            oldItem.Description = updatedItem.Description;
            oldItem.Quantity = updatedItem.Quantity;
            oldItem.Price = updatedItem.Price;

            ORM.Entry(oldItem).State = EntityState.Modified;
            ORM.SaveChanges();
            return RedirectToAction("Items", "Home");
        }

        public ActionResult DeleteItem(int itemID)
        {
            CoffeeShopDBEntities1 ORM = new CoffeeShopDBEntities1();
            Item found = ORM.Items.Find(itemID);

            ORM.Items.Remove(found);
            ORM.SaveChanges();
            return RedirectToAction("Items", "Home");
        }
    }

}