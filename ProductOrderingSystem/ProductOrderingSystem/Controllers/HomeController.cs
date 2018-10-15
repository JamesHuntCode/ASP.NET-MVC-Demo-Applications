using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProductOrderingSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Models.Product p = new Models.Product();
            p.Product_Code = "SOFT549";
            p.Product_Name = "Book";

            using (var db = new Models.ProductDB())
            {
                db.Products.Add(p);
                db.SaveChanges();
                ViewBag.Message = "The number of products so far is " + db.Products.Count().ToString();
            }
            return View();
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
    }
}