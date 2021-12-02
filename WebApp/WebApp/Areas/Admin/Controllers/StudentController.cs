using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Areas.Admin.Controllers
{
    public class StudentController : Controller
    {
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

        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult CreateStudentUser()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateStudentUser(StudentCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                //todo :
                //step 1 : Create User
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = model.Email, PhoneNumber = model.Phone, Email = model.Email };
                userManager.Create(userToInsert, model.Password);

                //Step 2 : Create Student
                var student = new Student()
                {
                    Email = model.Email,
                    Name = model.Name,
                    Phone = model.Phone,
                    StandardId = model.StandardId,
                    UserId = userToInsert.Id
                };
                db.Students.Add(student);
                db.SaveChanges();
                //Step 3 : Assign User as Student
                userManager.AddToRole(userToInsert.Id, "Student");
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
