using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebECom.Models;

namespace WebECom.Layers.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext db;

        public CategoryRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
    }

    public interface ICategoryRepository
    {
    }
}
