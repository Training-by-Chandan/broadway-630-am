using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesktop.Model
{
    public class UserInfo
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles Roles { get; set; }
    }

    public enum Roles
    {
        Student = 1,
        Teacher = 2,
        Admin = 3
    }
}
