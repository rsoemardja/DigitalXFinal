using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DigitalXData;

namespace DigitalXMVC.Controllers
{
    public class HomeController : Controller
    {
        AuthServiceReference.AuthServiceClient pr = new AuthServiceReference.AuthServiceClient();

        public ActionResult Index()
        {
            return View(pr.ProductGetTop(5).ToList());
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AddToShoppingCart(Product product)
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