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
    }
}
