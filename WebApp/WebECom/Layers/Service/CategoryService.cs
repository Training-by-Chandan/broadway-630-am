using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebECom.Layers.Data;

namespace WebECom.Layers.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;

        public CategoryService(
            ICategoryRepository categoryRepository
            )
        {
            this.categoryRepository = categoryRepository;
        }
    }

    public interface ICategoryService
    {
    }
}
