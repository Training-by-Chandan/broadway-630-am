using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebECom.Layers.Service;

namespace WebECom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;

        public HomeController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Exception thrown intentionally");
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            //sending email
            //Thread.Sleep(10000);
            return View();
        }
    }
}
