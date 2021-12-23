using System.ComponentModel.DataAnnotations.Schema;

namespace WebECom.Models
{
    public class Product : Basemodel
    {
        public string Title { get; set; }
        public int? CategoryId { get; set; }
        public string PhotoPath { get; set; }

        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
