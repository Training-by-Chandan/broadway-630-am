using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.ViewModel;

namespace WebApp.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        public ActionResult abc()
        {
            var list = GenerateDummyList();
            return View(list);
        }

        private List<StudentViewModel> GenerateDummyList()
        {
            var list = new List<StudentViewModel>();
            list.Add(new StudentViewModel(1, "Sadhit", "sadhit@gmail.com"));
            list.Add(new StudentViewModel(2, "Pratik", "pratik@gmail.com"));
            list.Add(new StudentViewModel(3, "Bashanta", "bashanta@gmail.com"));
            list.Add(new StudentViewModel(4, "Kishor", "kishor@gmail.com"));
            list.Add(new StudentViewModel(5, "Rainy", "rainy@gmail.com"));
            list.Add(new StudentViewModel(6, "Ruman", "ruman@gmail.com"));
            list.Add(new StudentViewModel(7, "Chandan", "chandan@gmail.com"));

            return list;
        }
    }
}
