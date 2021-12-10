using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebECom.Models;

namespace WebECom.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public (bool, string, int) Create(Category model)
        {
            try
            {
                db.Categories.Add(model);
                db.SaveChanges();
                return (true, "Success", model.Id);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);
            }
        }

        public (bool, string, int) Update(Category model)
        {
            try
            {
                var existing = db.Categories.Find(model.Id);
                if (existing == null) return (false, "Not found", model.Id);

                existing.Title = model.Title;
                existing.Status = model.Status;
                existing.Description = model.Description;
                existing.ParentCategoryId = model.ParentCategoryId;
                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return (true, "Success", model.Id);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);
            }
        }

        public (bool, string) Delete(Category model)
        {
            try
            {
                var existing = db.Categories.Find(model.Id);
                if (existing == null) return (false, "Not found");
                db.Categories.Remove(existing);
                db.SaveChanges();
                return (true, "Success");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public IQueryable<Category> GetAll()
        {
            return db.Categories.AsQueryable();
        }

        public Category GetById(int Id)
        {
            return db.Categories.Find(Id);
        }
    }

    public interface ICategoryRepository
    {
        (bool, string, int) Create(Category model);

        (bool, string, int) Update(Category model);

        (bool, string) Delete(Category model);

        IQueryable<Category> GetAll();

        Category GetById(int Id);
    }
}
