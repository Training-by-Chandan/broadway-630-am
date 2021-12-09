using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebECom.Layers.Data;
using WebECom.Models;
using WebECom.ViewModel;

namespace WebECom.Layers.Service
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository categoryRepository;
        private readonly IMapper mapper;

        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper
            )
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public (bool, string, int) Create(CategoryViewModel model)
        {
            try
            {
                //var category = model.ConvertToModel();
                var category = mapper.Map<CategoryViewModel, Category>(model);
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
            var data = categoryRepository.GetAll().ToList();
            var list = mapper.Map<List<Category>, List<CategoryViewModel>>(data);
            return list;
            //var list = new List<CategoryViewModel>();
            //foreach (var item in data)
            //{
            //    var catvm = new CategoryViewModel();
            //    catvm.ConvertFromModel(item);
            //    list.Add(catvm);
            //}
            //return list;
        }
    }

    public interface ICategoryService
    {
        (bool, string, int) Create(CategoryViewModel model);

        IEnumerable<SelectListItem> GetList();

        IEnumerable<CategoryViewModel> GetAll();
    }
}
