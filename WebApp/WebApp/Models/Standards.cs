using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class Standards
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
