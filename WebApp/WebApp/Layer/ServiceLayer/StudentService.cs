using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Layer.DataLayer;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Layer.ServiceLayer
{
    public class StudentService : IStudentService
    {
        private IStudentRepository studentRepository = new StudentRepository();

        public bool CreateStudentUser(StudentCreateViewModel model)
        {
            try
            {
                //todo :
                //step 1 : Create User
                ApplicationUser userToInsert = CreateUserForStudent(model);
                //Step 2 : Create Student
                var student = new Student()
                {
                    Email = model.Email,
                    Name = model.Name,
                    Phone = model.Phone,
                    StandardId = model.StandardId,
                    UserId = userToInsert.Id
                };
                studentRepository.Create(student);

                //Step 3 : Assign User as Student
                AddRoleToStudent(userToInsert);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        private static void AddRoleToStudent(ApplicationUser userToInsert)
        {
            var userStore = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var userManager = new UserManager<ApplicationUser>(userStore);
            userManager.AddToRole(userToInsert.Id, "Student");
        }

        private static ApplicationUser CreateUserForStudent(StudentCreateViewModel model)
        {
            var userStore = new UserStore<ApplicationUser>(new ApplicationDbContext());
            var userManager = new UserManager<ApplicationUser>(userStore);
            var userToInsert = new ApplicationUser { UserName = model.Email, PhoneNumber = model.Phone, Email = model.Email };
            userManager.Create(userToInsert, model.Password);
            return userToInsert;
        }
    }

    public interface IStudentService
    {
        bool CreateStudentUser(StudentCreateViewModel model);
    }
}
