using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Attribs;
using WebApp.Layer.ServiceLayer;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Admin/Student
        public ActionResult Index()
        {
            var data = (from s in db.Students.AsQueryable()
                        select new StudentListViewModel
                        {
                            StudentId = s.Id,
                            Email = s.Email,
                            Name = s.Name,
                            Phone = s.Phone,
                            StandardName = s.Standards == null ? "" : s.Standards.Name
                        }).ToList();

            //ViewData["StadardId"] = classlist;

            return View(data);
        }

        public ActionResult Details(int studentId)
        {
            var data = (from s in db.Students.AsQueryable()
                        where s.Id == studentId
                        select new StudentListViewModel
                        {
                            StudentId = s.Id,
                            Email = s.Email,
                            Name = s.Name,
                            Phone = s.Phone,
                            StandardName = s.Standards == null ? "" : s.Standards.Name
                        }).FirstOrDefault();

            return View(data);
        }

        public ActionResult CreateStudentUser()
        {
            ViewBag.Classlist = standardService.GetStandardsList();
            return View();
        }

        private IStudentService studentService = new StudentService();
        private IStandardService standardService = new StandardService();

        [HttpPost]
        [TwelveFilter]
        public ActionResult CreateStudentUser(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (studentService.CreateStudentUser(model))
                {
                    return RedirectToAction("Index");
                }
            }
            ViewBag.Classlist = standardService.GetStandardsList();
            return View(model);
        }
    }
}
