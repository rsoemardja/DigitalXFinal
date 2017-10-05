using DigitalXData;
using DigitalXMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


namespace DigitalXMVC.Controllers
{
    public class CartController : Controller
    {
        DigitalXDBEntities db = new DigitalXDBEntities();
        ShoppingCartModels cart;

        // GET: Cart
        public ActionResult CartAdd(int id, int quantity)
        {
            cart = ShoppingCartModels.GetCart(this.ControllerContext.HttpContext);
            Product prod = db.Products.Find(id);
            int res = cart.AddToCart(prod, quantity);
            return Content("All good - you now have the following quantity of this item: " + res);
        }

        public ActionResult CartRemove(int id)
        {
            cart = ShoppingCartModels.GetCart(this.ControllerContext.HttpContext);
            int res = cart.RemoveFromCart(id);
            return Content("All good - you now have the following quantity of this item: " + res, "text/html");
        }
        public ActionResult CartClear()
        {
            cart = ShoppingCartModels.GetCart(this.ControllerContext.HttpContext);
            cart.EmptyCart();
            return Content("All good");
        }

        public ActionResult AddToCart(Product product)
        {
            List<Product> listProducts;
            if (Session["ShoppingCart"] == null)
            {
                listProducts = new List<Product>();
                listProducts.Add(product);
                Session["ShoppingCart"] = listProducts;
            }
            else
            {
                listProducts = (List<Product>)Session["ShoppingCart"];
                listProducts.Add(product);
                Session["ShoppingCart"] = listProducts;
            }
            return RedirectToAction("Index");
        }

    }
}