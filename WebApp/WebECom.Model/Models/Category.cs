using System.ComponentModel.DataAnnotations.Schema;

namespace WebECom.Models
{
    public class Category : Basemodel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ParentCategoryId { get; set; }

        [ForeignKey("ParentCategoryId")]
        public virtual Category Parent { get; set; }
    }

    public class Product : Basemodel
    {
        public string Title { get; set; }
        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
