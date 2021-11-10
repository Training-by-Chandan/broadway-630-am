using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCodeFirst
{
    //Step 1 : Install the package : EntityFramework
    //step 2 : Create a blank database and add the connectionstring to app.config/web.config
    //step 3: Create a context class (defaultContext)
    //step 4 : Create a model and link it up in contextclass
    //step 5 : Enable migration using enable-migrations in powershell
    //step 6 : add-migration
    //step 7 : update-database

    internal class Program
    {
        public static DefaultContext db = new DefaultContext();

        private static void Main(string[] args)
        {
            CreateTeacher();

            ListTeacher();

            Console.ReadLine();
        }

        private static void CreateTeacher()
        {
            Teacher t = new Teacher();
            Console.WriteLine("Enter Teacher Name ");
            t.TeacherName = Console.ReadLine();
            Console.WriteLine("Enter Subject Name");
            t.Subject = Console.ReadLine();

            db.Teachers.Add(t);
            db.SaveChanges();
        }

        private static void ListTeacher()
        {
            var data = db.Teachers.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id => {item.Id}, Teacher Name => {item.TeacherName}, Subject =>{item.Subject}");
            }
        }
    }
}
