using MyDesktop.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDesktop.Data
{
    public class DefaultContext : DbContext
    {
        public DefaultContext() : base("name=Default")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
