using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Models;

namespace WebApp.Layer.DataLayer
{
    public class StudentRepository : RepositoryBase, IStudentRepository
    {
        public bool Create(Student model)
        {
            try
            {
                db.Students.Add(model);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public interface IStudentRepository
    {
        bool Create(Student model);
    }
}
