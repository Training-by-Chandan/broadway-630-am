using ConsoleDatabaseFirst.DatabaseFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDatabaseFirst
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            InsertPersonal();

            ListPersonal();

            Console.ReadLine();
        }

        public static SomeDbEntities db = new SomeDbEntities();

        public static void ListPersonal()
        {
            var data = db.Personals.ToList();
            foreach (var item in data)
            {
                Console.WriteLine($"Id => {item.id}, Full Name => {item.first_name} {item.last_name}");
            }
        }

        private static void InsertPersonal()
        {
            Personal p = new Personal();
            Console.WriteLine("Enter FirstName ");
            p.first_name = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            p.last_name = Console.ReadLine();

            db.Personals.Add(p);
            db.SaveChanges();
        }

        private static void UpdatePersonal()
        {
            Console.WriteLine("Enter Id ");
            var id = Convert.ToInt32(Console.ReadLine());

            var personal = db.Personals.Find(id);

            if (personal != null)
            {
                Console.WriteLine("Enter FirstName ");
                personal.first_name = Console.ReadLine();
                Console.WriteLine("Enter LastName");
                personal.last_name = Console.ReadLine();

                db.Entry(personal).State = System.Data.Entity.EntityState.Modified;

                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Person not found");
            }
        }

        private static void DeletePersonal()
        {
            Console.WriteLine("Enter Id ");
            var id = Convert.ToInt32(Console.ReadLine());
            var personal = db.Personals.Find(id);
            if (personal != null)
            {
                //db.sp_createStudentParent("", "", "");
                var data = db.sp_studentparentinfo();
                db.Personals.Remove(personal);
                db.SaveChanges();
            }
            else
            {
                Console.WriteLine("Person not found");
            }
        }
    }
}
