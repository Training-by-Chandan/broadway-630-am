using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Test();

            //DataTypeExplanation();

            //DateTimeExample();

            StringConcatenation();

            Console.ReadLine();
            return;
        }

        private static void StringConcatenation()
        {
            string[] strArr = new string[5];
            strArr[0] = "A";
            strArr[1] = "B";
            strArr[2] = "C";
            strArr[3] = "D";
            strArr[4] = "E";

            //basic concatenation
            string s1 = "Hello!";
            string s2 = "World";
            var s3 = s1 + " " + s2;

            //string formatting
            var s4 = "{0} beautiful {1}";
            var s5 = string.Format(s4, s1, s2);
            Console.WriteLine("{0} {1} {2} {3} {4}", strArr);
            var baseurl = "http://chandanbhagat.com.np";
            var otherurl = "http://chandanbhagat.com.np\\v1\\{0}";
            var contact = string.Format(otherurl, "contact");
            var about = string.Format(otherurl, "about");
            var template = "hi {0}, your otp is {1}. Do not share your otp with anyone";

            //string interpolation
            var s6 = $"{s1} beautiful {s2}";
            Console.WriteLine(s6);

            //string builder
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello! ");
            sb.Append("A standard TimeSpan format string uses a single format specifier to define the text representation of a TimeSpan value that results from a formatting operation.");
            sb.Append("Any format string that contains more than one character, including white space, is interpreted as a custom TimeSpan format string. For more information, see Custom TimeSpan format strings .");

            var output = sb.ToString();
            Console.WriteLine(output);
        }

        private static void DateTimeExample()
        {
            var dateTime = DateTime.Now;
            var date = dateTime.Date;

            Console.WriteLine("DateTime Now => " + dateTime);
            Console.WriteLine("Date Now => " + date);

            string Str = dateTime.ToString("dd, MMMM-yyyy");
            Console.WriteLine("Formatted Date => " + Str);
            var DateNew = new DateTime(1991, 11, 21);
            Console.WriteLine("DateNew => " + DateNew);

            dateTime = dateTime.AddDays(1);
            Console.WriteLine("DateTime Now => " + dateTime);

            var time = dateTime.TimeOfDay;
            Console.WriteLine("Time => " + dateTime.ToString("HH:mm:ss"));

            var date1 = DateTime.Now;
            var date2 = new DateTime(1995, 1, 15); //12:00:00 AM
            var diff = date1 - date2;
            var totalhous = diff.TotalHours;
            var years = diff.TotalHours / (365 * 24);
            Console.WriteLine("Diff => " + diff.Hours + "hours " + diff.Minutes + " minutes " + diff.Seconds + " seconds. ");
        }

        private static void DataTypeExplanation()
        {
            //data types
            //int32(int), char, int16(short), int64(long),
            //uint, uint16, uint64
            //decimal, float, double, string, datetime, bool
            decimal f = 10.04m;
            int i = 30;
            char c = 'C';
            int i1 = 'R';//implicit casting
            char c1 = (char)30; //explicit casting

            //implicit casting
            char c2 = 'Z';
            int i2 = c2;
            long l2 = i2;
            float f2 = l2;
            double d2 = f2;

            //explicit casting
            double d3 = 100.2345d;
            float f3 = (float)d3;
            long l3 = (long)f3;
            int i3 = (int)l3;
            char c3 = (char)i3;

            string s1 = d3.ToString();
            s1 = f3.ToString();
            s1 = false.ToString();

            var aa = 10;
            aa = 'A';// possible due to implicit casting
            aa = (int)1.2d; //possible due to explicit casting
            var ab = "";
            var ac = 1.2;

            object o1 = 1;
            o1 = "";
            o1 = 1.2d;
            object o2 = "";
            object o3 = true;

            string s2 = 123.23.ToString(); //s2="123"
            int i4 = (int)Convert.ToDouble(s2);
        }

        private static void Test()
        {
            Console.WriteLine("Enter your Name");

            string s = Console.ReadLine();

            Console.WriteLine("Hello! " + s);
        }

        private static int Add(int a, int b)
        {
            return a + b;
        }

        private static int Subtract(int a, int b) => a - b;
    }
}