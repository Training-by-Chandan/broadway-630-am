using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebECom.Models;

namespace WebECom.ViewModel
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }
        public string ParentCategoryName { get; set; }
        public bool Status { get; set; }

        public void ConvertFromModel(Category category)
        {
            this.Id = category.Id;
            this.ParentCategoryId = category.ParentCategoryId;
            this.Title = category.Title;
            this.Status = category.Status;
            this.Description = category.Description;
            this.ParentCategoryName = category.Parent == null ? "" : category.Parent.Title;
        }

        public Category ConvertToModel()
        {
            var category = new Category();
            category.Id = this.Id;
            category.ParentCategoryId = this.ParentCategoryId;
            category.Title = this.Title; ;
            category.Status = this.Status;
            category.Description = this.Description;

            return category;
        }
    }
}
