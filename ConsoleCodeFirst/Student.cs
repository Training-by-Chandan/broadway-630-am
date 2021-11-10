using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    public class Student
    {
        public int Id { get; set; }// automatically a primary key with identity(1,1)

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }
    }

    public class Teacher
    {
        public int Id { get; set; }
        public string TeacherName { get; set; }
        public string Subject { get; set; }
    }
}
