using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebECom.Services;
using WebECom.ViewModel;

namespace WebECom.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService categoryService;

        public CategoryController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        // GET: Category
        public ActionResult Index()
        {
            var data = categoryService.GetAll();
            return View(data);
        }

        public ActionResult Create()
        {
            ViewBag.parent = categoryService.GetList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(CategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = categoryService.Create(model);
                if (result.Item1)
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.parent = categoryService.GetList();
            return View(model);
        }
    }
}
