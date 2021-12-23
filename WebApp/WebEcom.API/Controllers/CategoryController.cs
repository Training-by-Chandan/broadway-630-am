using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using WebECom.Services;
using WebECom.ViewModel;

namespace WebEcom.API.Controllers
{
    //[Authorize]
    
    public class CategoryController : ApiController
    {
        private readonly ICategoryService categoryService;

        public CategoryController(
            ICategoryService categoryService
            )
        {
            this.categoryService = categoryService;
        }

        public List<CategoryViewModel> GetAllCategory()
        {
            return categoryService.GetAll().ToList();
        }
    }
}
