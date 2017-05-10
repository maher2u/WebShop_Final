using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CartsController : Controller
    {
        private DatabaseModel db = new DatabaseModel();

        // GET: Active Cart
        public ActionResult Index()
        {
            if (Session["customer"] != null)
            {
                int id = ((Customer)Session["customer"]).ID;
                var orders = db.Orders.Where(o => o.cart.status == "active" && o.cart.customerID == id).Include(o => o.cart).Include(o => o.product);
                return View(orders.ToList());
            }
            return HttpNotFound();
        }

        // GET: Order
        public ActionResult Order(int? cartID)
        {
            if (Session["customer"] != null)
            {
                var order = db.Orders.Where(o => o.cart.status == "ordered" && o.cart.ID == cartID);
                return View(order.ToList());
            }
            return HttpNotFound();
        }

        // POST: Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add([Bind(Include = "ID, Amount, CartID, ProductID")] Order order)
        {
            if (Session["customer"] != null)
            {
                if (ModelState.IsValid)
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }

            return RedirectToAction("Login", "Account");
        }

        // POST: Remove
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int? id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Order
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Order()
        {
            int customerID = ((Customer)Session["customer"]).ID;

            Cart cart = new Cart();
            cart.customerID = customerID;
            cart.status = "active";
            db.Carts.Add(cart);

            Cart order = db.Carts.Where(o => o.customerID == customerID && o.status == "active").First();
            order.status = "ordered";
            db.Entry(order).State = EntityState.Modified;

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}