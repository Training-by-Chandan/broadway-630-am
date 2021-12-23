using System;
using System.Linq;
using WebECom.Models;

namespace WebECom.Repository
{
    public interface IProductRepository
    {
        (bool, string, int) Create(Product model);

        (bool, string) Delete(Product model);

        IQueryable<Product> GetAll();

        Product GetById(int Id);

        (bool, string, int) Update(Product model);
    }

    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext db;

        public ProductRepository(ApplicationDbContext db)
        {
            this.db = db;
        }

        public (bool, string, int) Create(Product model)
        {
            try
            {
                db.Products.Add(model);
                db.SaveChanges();
                return (true, "Success", model.Id);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);
            }
        }

        public (bool, string, int) Update(Product model)
        {
            try
            {
                var existing = db.Products.Find(model.Id);
                if (existing == null) return (false, "Not found", model.Id);

                existing.Title = model.Title;
                existing.Status = model.Status;
                existing.CategoryId = model.CategoryId;
                db.Entry(existing).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return (true, "Success", model.Id);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);
            }
        }

        public (bool, string) Delete(Product model)
        {
            try
            {
                var existing = db.Products.Find(model.Id);
                if (existing == null) return (false, "Not found");
                db.Products.Remove(existing);
                db.SaveChanges();
                return (true, "Success");
            }
            catch (Exception ex)
            {
                return (false, ex.Message);
            }
        }

        public IQueryable<Product> GetAll()
        {
            return db.Products.AsQueryable();
        }

        public Product GetById(int Id)
        {
            return db.Products.Find(Id);
        }
    }
}
