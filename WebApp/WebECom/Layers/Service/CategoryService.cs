using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebECom.Layers.Data;
using WebECom.ViewModel;

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

        public (bool, string, int) Create(CategoryViewModel model)
        {
            try
            {
                var category = model.ConvertToModel();
                return categoryRepository.Create(category);
            }
            catch (Exception ex)
            {
                return (false, ex.Message, 0);
            }
        }

        public IEnumerable<SelectListItem> GetList()
        {
            var data = categoryRepository.GetAll().Select(p => new SelectListItem { Text = p.Title, Value = p.Id.ToString() });
            return data;
        }
        public IEnumerable<CategoryViewModel> GetAll()
        {
            var data = categoryRepository.GetAll();
            var list = new List<CategoryViewModel>();
            foreach (var item in data)
            {
                var catvm = new CategoryViewModel();
                catvm.ConvertFromModel(item);
                list.Add(catvm);
            }
            return list;
        }
    }

    public interface ICategoryService
    {
        (bool, string, int) Create(CategoryViewModel model);

        IEnumerable<SelectListItem> GetList();
        IEnumerable<CategoryViewModel> GetAll();
    }
}
