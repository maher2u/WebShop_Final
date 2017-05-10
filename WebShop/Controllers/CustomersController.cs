using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class CustomersController : Controller
    {
        private DatabaseModel db = new DatabaseModel();


        // GET: Customer
        public ActionResult Account()
        {
            if (Session["customer"] != null)
            {
                int id = ((WebShop.Models.Customer)Session["customer"]).ID;
                Customer customer = db.Customers.Find(id);

                var orders = db.Carts.Where(o => o.status == "ordered");

                if (customer != null)
                {
                    ViewBag.customer = customer;
                    ViewBag.orders = orders.ToList();
                    return View(customer);
                }
            }

            return HttpNotFound();
        }

        // GET: Customers/Register
        public ActionResult Register()
        {
            return View();
        }

        // POST: Customers/Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register([Bind(Include = "ID,email,password,firstname,lastname,gender")] Customer customer)
        {
            if (ModelState.IsValid && customer.Email != null && customer.Password != null && customer.FirstName != null && customer.LastName != null)
            {
                Cart cart = new Cart();
                cart.customerID = customer.ID;
                cart.status = "active";

                db.Customers.Add(customer);
                db.Carts.Add(cart);
                db.SaveChanges();

                Session["customer"] = customer;
                return RedirectToAction("Index", "ChoosingProducts");
            }

            return View(customer);
        }

        // GET: Customers/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Customers/Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login([Bind(Include = "ID,email,password,firstname,lastname,gender")] Customer customer)
        {
            if (db.Customers.ToList().Any(cus => cus.Email == customer.Email && cus.Password == customer.Password))
            {
                var query = from a in db.Customers
                            where a.Email.Contains(customer.Email) & a.Password.Contains(customer.Password)
                            select a;
                var login = query.FirstOrDefault();

                Session["customer"] = login;
                return RedirectToAction("login", "Account");
            }

            return View(customer);
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("login", "Account");
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