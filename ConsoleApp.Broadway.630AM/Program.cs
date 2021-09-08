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

            //StringConcatenation();

            //ArrayExample();

            StringManipulation();

            Console.ReadLine();
            return;
        }

        private static void LoopingStatementExample()
        {
        }

        private static void BranchingStatementExample()
        {
            Console.WriteLine("Enter the day number");
            var str = Console.ReadLine();
            var choice = Convert.ToInt32(str);
            //todo : Chandan : Need to implement some ideas here

            #region If Then Else Code Block

            string day = "";
            if (str == "1")
                day = "Sunday";
            else if (str == "2")
                day = "Monday";
            else if (str == "3")
                day = "Tuesday";
            else if (str == "4")
                day = "Wednesday";
            else if (str == "5")
                day = "Thursday";
            else if (str == "6")
                day = "Friday";
            else if (str == "7")
                day = "Saturday";
            else
                day = "Not a valid day";

            var dayNew = str == "1" ? "Sunday" : str == "2" ? "Monday" : str == "3" ? "Tuesday" : str == "4" ? "Wednesday" : str == "5" ? "Thursday" : str == "6" ? "Friday" : str == "7" ? "Saturday" : "Not a valid day";
            string dayType = "";
            if (str == "1" || str == "7")
            {
                dayType = "Weekends";
            }
            else if (str == "2" || str == "3" || str == "4" || str == "5" || str == "6")
            {
                dayType = "Weekdays";
            }
            else
            {
                dayType = "not a valid day type";
            }

            #endregion If Then Else Code Block

            #region Switch Case Code Block

            //using switch case here
            var day_sw = "";
            switch (str)
            {
                case "1":
                    day_sw = "Sunday";
                    break;

                case "2":
                    day_sw = "Monday";
                    break;

                case "3":
                    day_sw = "Tuesday";
                    break;

                case "4":
                    day_sw = "Wednesday";
                    break;

                case "5":
                    day_sw = "Thursday";
                    break;

                case "6":
                    day_sw = "Friday";
                    break;

                case "7":
                    day_sw = "Saturday";
                    break;

                default:
                    day_sw = "Not a valid day";
                    break;
            }

            var dayType_sw = "";
            switch (str)
            {
                case "1":
                case "7":
                    dayType_sw = "Weekends";
                    break;

                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                    dayType_sw = "Weekdays";
                    break;

                default:
                    dayType_sw = "Not a valid day type";
                    break;
            }

            #endregion Switch Case Code Block
        }

        private static void StringManipulation()
        {
            string[] str = new string[] { "Hari", "Rainy", "Pratik", "Ruman", "Kishor", "Basanta" };

            var joined = string.Join("-", str);
            var someText = "            the quick brown fox jumps over    the   lazy     dog           ";
            someText = someText.Replace("the", "a");
            var quickPresent = someText.Contains("quick");
            var totallength = someText.Count();
            someText = someText.Trim();
            var subStr = someText.Substring(3, 5);

            var splittedText = someText.Split(' ');
        }

        private static void ArrayExample()
        {
            int[] i = new int[5];
            //0 to 4
            i[0] = 10;
            i[1] = 11;
            i[2] = 5;
            i[3] = 7;
            i[4] = 9;
            Array.Reverse(i);
            Array.Resize(ref i, i.Length + 2);
            int[] k = new int[3];
            Array.Copy(i, 2, k, 1, 2);
            k[0] = i[1];
            int[] j = new int[] { 1, 3, 5, 7, 8, 9 };
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
            Console.WriteLine("{0} {1} {2} {3} {4} {0} {0} {2}", strArr);
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