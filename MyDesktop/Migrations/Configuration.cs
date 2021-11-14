namespace MyDesktop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MyDesktop.Data.DefaultContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MyDesktop.Data.DefaultContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            var student = new Model.Student() { FirstName = "Admin", LastName = "Admin", DOB = new DateTime(2020, 01, 01) };

            var existing = context.Students.Any(p => p.FirstName == student.FirstName && p.LastName == student.LastName && p.DOB == student.DOB);

            if (!existing)
            {
                context.Students.Add(student);
                context.SaveChanges();
            }
        }
    }
}
