using System.ComponentModel.DataAnnotations.Schema;

namespace WebECom.Models
{
    public class Basemodel
    {
        [Column(Order =1)]
        public int Id { get; set; }
        public bool Status { get; set; }
    }
}