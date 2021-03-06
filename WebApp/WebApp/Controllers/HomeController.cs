using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult ABC()
        {
            return View();
        }

        public ActionResult XYZ(int test, string x)
        {
            if (!string.IsNullOrWhiteSpace(Request.QueryString["y"]))
            {
                Response.StatusCode = 400;
            }
            ViewBag.test = test * 2;
            ViewBag.x = x + " " + x;
            Response.ContentType = "text/html";
            return View();
        }
    }
}
