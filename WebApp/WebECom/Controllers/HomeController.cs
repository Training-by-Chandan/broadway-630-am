using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using WebECom.Services;

namespace WebECom.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IEmailSenderService emailSenderService;

        public HomeController(
            ICategoryService categoryService,
            IEmailSenderService emailSenderService
            )
        {
            this.categoryService = categoryService;
            this.emailSenderService = emailSenderService;
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
            emailSenderService.SendEmail();
            return View();
        }
    }
}
