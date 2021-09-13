using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    //everything / every members in the static class should be static
    //object cannot be created
    public static class StaticClass
    {
        static StaticClass()
        {
        }

        private static int i = 10;
        public static int j { get; set; }

        public static void TestFunction()
        {
        }
    }

    //non static members can be accessed through object
    //to access static members, we dont have to create object
    //a nonstatic members can access static members but it is in shared mode (like public properties)
    //a non static members can access non static members as if it is their own (like a private properties)
    public class NonStaticClass
    {
        public int i = 10;
        public static int iStatic = 10;

        public int j { get; set; }
        public static int jStatic { get; set; }

        public void TestFunction()
        {
            i++;
            iStatic++;
            j++;
            jStatic++;

            Console.WriteLine($"i=>{i}\niStatic={iStatic}\nj={j}\njStatic={jStatic}");
        }

        public static void TestFunctionStatic()
        {
        }
    }
}