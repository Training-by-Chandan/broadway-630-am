using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebECom.Models;
using WebECom.Services;
using WebECom.ViewModel;

namespace WebECom.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService productService;
        private readonly ICategoryService categoryService;

        public ProductsController(
            IProductService productService,
            ICategoryService categoryService
            )
        {
            this.productService = productService;
            this.categoryService = categoryService;
        }

        // GET: Products
        public ActionResult Index()
        {
            var products = productService.GetAll();
            return View(products.ToList());
        }

        //// GET: Products/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        // GET: Products/Create
        public ActionResult Create()
        {
            ViewBag.CategoryId = categoryService.GetList();
            return View();
        }

        // POST: Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel product)
        {
            if (ModelState.IsValid)
            {
                productService.Create(product);
                return RedirectToAction("Index");
            }

            ViewBag.CategoryId = categoryService.GetList();
            return View(product);
        }

        //// GET: Products/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Title", product.CategoryId);
        //    return View(product);
        //}

        //// POST: Products/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to, for
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Title,CategoryId,PhotoPath,Status")] Product product)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(product).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    ViewBag.CategoryId = new SelectList(db.Categories, "Id", "Title", product.CategoryId);
        //    return View(product);
        //}

        //// GET: Products/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}

        //// POST: Products/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Product product = db.Products.Find(id);
        //    db.Products.Remove(product);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}
        [HttpGet]
        public ActionResult AddToCart(int productId, bool add = true)
        {
            var existing = productService.GetById(productId);
            if (existing != null)
            {
                var sessionObj = Session["cart"] as List<SessionModel>;
                if (sessionObj == null)
                {
                    sessionObj = new List<SessionModel>();
                    sessionObj.Add(new SessionModel
                    {
                        Price = existing.Price,
                        ProductId = productId,
                        ProductName = existing.Title,
                        Quantity = add ? 1 : 0
                    });
                }
                else
                {
                    var session = sessionObj.FirstOrDefault(p => p.ProductId == productId);
                    if (session == null)
                    {
                        sessionObj.Add(new SessionModel
                        {
                            Price = existing.Price,
                            ProductId = productId,
                            ProductName = existing.Title,
                            Quantity = add ? 1 : 0
                        });
                    }
                    else
                    {
                        session.Quantity = add ? session.Quantity + 1 : session.Quantity - 1;
                    }
                }
                Session["cart"] = sessionObj;
            }

            //add this to sesstion
            return RedirectToAction("Index");
        }

        public ActionResult ListCart()
        {
            var cook = new HttpCookie("name", "Chandan");
            cook.Expires = DateTime.Now.AddSeconds(30);
            Response.Cookies.Set(cook);
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }
    }
}
