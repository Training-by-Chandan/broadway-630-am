using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter the name of student")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        public int? StandardId { get; set; }

        [ForeignKey("StandardId")]
        public virtual Standards Standards { get; set; }
    }

    public class Standards
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
