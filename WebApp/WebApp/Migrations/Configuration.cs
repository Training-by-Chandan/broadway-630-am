namespace WebApp.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApp.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext db)
        {
            var roleStore = new RoleStore<IdentityRole>(db);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            if (!(db.Roles.Any(p => p.Name == "Admin")))
            {
                roleManager.Create(new IdentityRole() { Name = "Admin" });
            }
            if (!(db.Roles.Any(p => p.Name == "Student")))
            {
                roleManager.Create(new IdentityRole() { Name = "Student" });
            }

            if (!(db.Users.Any(u => u.UserName == "admin@admin.com")))
            {
                var userStore = new UserStore<ApplicationUser>(db);
                var userManager = new UserManager<ApplicationUser>(userStore);
                var userToInsert = new ApplicationUser { UserName = "admin@admin.com", PhoneNumber = "12345678911", Email = "admin@admin.com" };
                userManager.Create(userToInsert, "Admin@123");

                userManager.AddToRole(userToInsert.Id, "Admin");
            }
        }
    }
}
