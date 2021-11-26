using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public ActionResult abc()
        {
            return View("~/Views/Home/abc.cshtml");
        }
    }
}
