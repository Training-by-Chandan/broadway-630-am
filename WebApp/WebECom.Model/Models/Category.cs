using System.ComponentModel.DataAnnotations.Schema;

namespace WebECom.Models
{
    public class Category : Basemodel
    {
        /// <summary>
        /// Title of the category
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Description of the category
        /// </summary>
        public string Description { get; set; }

        public int? ParentCategoryId { get; set; }

        [ForeignKey("ParentCategoryId")]
        public virtual Category Parent { get; set; }
    }
}
