namespace WebECom.Migrations
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebECom.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebECom.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebECom.Models.ApplicationDbContext db)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var roleStore = new RoleStore<IdentityRole>(db);
            var roleManager = new RoleManager<IdentityRole>(roleStore);
            if (!db.Roles.Any(p => p.Name == "Admin"))
            {
                roleManager.Create(new IdentityRole("Admin"));
            }
            if (!db.Roles.Any(p => p.Name == "Vendor"))
            {
                roleManager.Create(new IdentityRole("Vendor"));
            }

            var userStore = new UserStore<ApplicationUser>(db);
            var usermanager = new UserManager<ApplicationUser>(userStore);
            if (!db.Users.Any(p => p.UserName.ToLower() == "admin@admin.com"))
            {
                var userToInsert = new ApplicationUser() { UserName = "admin@admin.com", Email = "admin@admin.com", PhoneNumber = "+977-0123456789" };
                var result = usermanager.Create(userToInsert, "Admin@123");
                if (result.Succeeded)
                {
                    usermanager.AddToRole(userToInsert.Id, "Admin");
                }
            }
            if (!db.Users.Any(p => p.UserName.ToLower() == "vendor@vendor.com"))
            {
                var userToInsert = new ApplicationUser() { UserName = "vendor@vendor.com", Email = "vendor@vendor.com", PhoneNumber = "+977-0123456789" };
                var result = usermanager.Create(userToInsert, "Vendor@123");
                if (result.Succeeded)
                {
                    usermanager.AddToRole(userToInsert.Id, "Vendor");
                }
            }
        }
    }
}
