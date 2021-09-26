using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Broadway._630AM.ABC;
using Library1;

namespace ConsoleApp.Broadway._630AM
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var choice = "n";
            do
            {
                //Test();

                //DataTypeExplanation();

                //DateTimeExample();

                //StringConcatenation();

                //ArrayExample();

                //StringManipulation();

                //BranchingStatementExample();

                //LoopingStatementExample();

                //EnumImplementations();

                //ClassExample();

                //OperatorOverloadingExample();

                //StaticAndNonStaticExplained();

                //InheritenceExample();

                //InheritenceV2();

                //InterfaceExample();

                //AbstractExample();

                //StackImplmentation();

                //StackImplementationV2();

                //LinqImpl();

                PassbyExamples();

                Console.WriteLine("Do you want to continue more? (y/n)");
                choice = Console.ReadLine();
            } while (choice.ToLower() == "y");
            Console.ReadLine();
            return;
        }

        private static void PassbyExamples()
        {
            int x = 2;
            int y = 1;

            var res = PassBy.Value(x, y);
            Console.WriteLine($"Value of x={x} and y={y}");
            res = PassBy.Value(x, y);
            Console.WriteLine($"Value of x={x} and y={y}");

            PassBy.Refernece(ref x, ref y);
            Console.WriteLine($"Value of x={x} and y={y}");
            PassBy.Value(x, y);
            Console.WriteLine($"Value of x={x} and y={y}");
            PassBy.Refernece(ref x, ref y);
            Console.WriteLine($"Value of x={x} and y={y}");
            int a = 0;
            PassBy.Out(x, y, out a);
        }

        private static void LinqImpl()
        {
            LinqExamples linq = new LinqExamples();
            linq.LinqImpl();
            linq.LinqImplV2();
        }

        private static void TemplateExamples()
        {
            var templates = new Templates<Circle, decimal>();

            templates.FunctionTwo<Human, float, int>(new Human(), 12.45f, 12);
        }

        public static void StackImplementationV2()
        {
            CustomStackV2<int> cs = new CustomStackV2<int>();
            cs.Push(12);
            cs.Push(13);
            cs.Push(14);
            cs.Push(15);
            cs.Push(16);
            cs.Push(17);
            cs.Push(18);

            cs.DisplayAll();
            cs.Peek();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.DisplayAll();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.DisplayAll();

            CustomStackV2<string> str = new CustomStackV2<string>();
            str.Push("abc");
        }

        private static void StackImplmentation()
        {
            CustomStack cs = new CustomStack();
            cs.Push(10);
            cs.Push(12);
            cs.Push(15);
            cs.DisplayAll();
            cs.Pop();
            cs.DisplayAll();
            cs.Push(8);
            cs.Push(3);
            cs.Push(67);
            cs.Push(12);
            cs.DisplayAll();
            cs.Peek();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            cs.Pop();
            Console.WriteLine("Enter the size of stack");
            var size = Convert.ToInt32(Console.ReadLine());
            CustomStack cs1 = new CustomStack(size);
        }

        private static void ExtensionFunctionExample()
        {
            Rectangle r = new Rectangle();
            //r.FunctionOne();
            r.FunctionNew();

            RectangleNew rnew = new RectangleNew();
            rnew.FunctionOne();
            int i = 10;
            i = i.increasebynum(5);

            string str = "something";
            str = str.AddDot();
        }

        private static ShapeAbs shapeAbs;

        private static void AbstractExample()
        {
            Console.WriteLine("Press\n1 for Rectangle\nothers for Square");
            var choice = Convert.ToInt32(Console.ReadLine());
            shapeAbs = FactoryShapeAbstract(choice);

            shapeAbs.GetInput();
            shapeAbs.Area();
            shapeAbs.Perimeter();
        }

        private static ShapeAbs FactoryShapeAbstract(int choice)
        {
            switch (choice)
            {
                case 1:
                    return new RectangleAbs();

                default:
                    return new SquareAbs();
            }
        }

        private static IShape shape;

        private static void InterfaceExample()
        {
            Console.WriteLine("Press\n1 for Rectangle\n2 for Square\n3 for Circle");
            var choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    shape = new Rectangle();
                    break;

                case 2:
                    shape = new Square();
                    break;

                case 3:
                    shape = new Circle();
                    break;

                default:
                    break;
            }

            shape.GetInput();
            shape.Area();
            shape.Perimeter();

            ////forceful conversion
            // var s1 = (Rectangle)shape;

            ////if casted successfully then ok else I will take null
            //var s = shape as Rectangle;
            //if (shape as Rectangle != null)
            //{
            //    Console.WriteLine("The shape is rectangle");
            //}
        }

        public static void InheritenceV2()
        {
            LivingThings l1 = new LivingThings(1);
            Animal a1 = new Animal();
            Plant p1 = new Plant();
            Human h1 = new Human();
            int i = 'C';
            Man m1 = new Man();
            ////implicit casting
            //l1 = a1;
            //l1 = p1;
            ////a1 = (Animal)(LivingThings)p1;
            //a1 = h1;

            ////explicit casting
            //h1 = (Human)a1;
            //a1 = (Animal)l1;
            //p1 = (Plant)l1;

            //l1 = p1;
            //a1 = (Animal)(LivingThings)p1;
            //p1 = (Plant)(LivingThings)a1;

            //l1 = h1;
            //p1 = (Plant)(LivingThings)h1;

            l1.Eat();
            Console.WriteLine(l1.ToString());
            Console.WriteLine();
            a1.Eat();
            Console.WriteLine(a1.ToString());
            Console.WriteLine();
            p1.Eat();
            Console.WriteLine(p1.ToString());
            Console.WriteLine();
            h1.Eat();
            Console.WriteLine(h1.ToString());
            Console.WriteLine();
            m1.Eat();
            Console.WriteLine(m1.ToString());
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void InheritenceExample()
        {
            //LivingThings l1 = new LivingThings();
            LivingThings l2 = new LivingThings(1);
            LivingThings l3 = new LivingThings("");

            Animal a1 = new Animal();
            Animal a2 = new Animal(1);
            Animal a3 = new Animal("");

            Class1 c1 = new Class1();

            //Plant p1 = new Plant();
            //Human h1 = new Human();
            //l1.Respire();
            //l1.Eat();
            //a1.Respire();
            //a1.Eat();
            //p1.Respire();
            //p1.Eat();
            //h1.Respire();
            //h1.Eat();
        }

        public static void StaticAndNonStaticExplained()
        {
            var something = StaticClass.j;
            StaticClass.TestFunction();
            Console.WriteLine();

            NonStaticClass nonStaticCLass = new NonStaticClass();
            NonStaticClass nonStaticCLass1 = new NonStaticClass();
            NonStaticClass nonStaticCLass2 = new NonStaticClass();
            NonStaticClass nonStaticCLass3 = new NonStaticClass();
            Console.WriteLine("nonStaticClass");
            nonStaticCLass.TestFunction();
            Console.WriteLine("nonStaticClass1");
            nonStaticCLass1.TestFunction();
            Console.WriteLine("nonStaticClass2");
            nonStaticCLass2.TestFunction();
            Console.WriteLine("nonStaticClass3");
            nonStaticCLass3.TestFunction();
        }

        public static void OperatorOverloadingExample()
        {
            int i = 1;
            int j = 2;
            int sum = i + j;
            i++;

            StudentMarks s1 = new StudentMarks("Chandan", "Bhagat") { MathMarks = 50, ScienceMarks = 30 };

            StudentMarks s2 = new StudentMarks("Default", "Default") { MathMarks = 50, ScienceMarks = 30 };

            StudentMarks s3 = s1 + s2 + s2 + s2 + s2;

            StudentMarks s4 = s1 - s3;

            s1++;

            var s5 = s1 + 5;

            var equals = s1 == s2;
        }

        public static void ClassExample()
        {
            //var h1=new Human();
            // Console.WriteLine(h1.Weight);
            // h1.Weight = 100;
            HumanBeing h1 = new HumanBeing();

            StudentMarks s1 = new StudentMarks();
            s1.AssignName("Chandan", "Bhagat");
            Console.WriteLine(s1.FullName);
            Console.WriteLine(s1.Intials);

            s1.AssignName("Pratik", "Bashyal");
            Console.WriteLine(s1.FullName);
            Console.WriteLine(s1.Intials);

            StudentMarks s2 = new StudentMarks();
            StudentMarks s5 = new StudentMarks();
            //s2.AssignName("Rainy", "Rijal");

            StudentMarks s3 = new StudentMarks("Pratik", "Bashyal");
            Guid guid = Guid.NewGuid();
            StudentMarks s4 = new StudentMarks("Chandan");
        }

        private static void EnumImplementations()
        {
            //var gender = Gender.Female;
            //Console.WriteLine(gender.ToString());
            //Console.WriteLine((int)gender);
            Console.WriteLine("Enter the day number ");
            var choice = (DaysEnum)Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case DaysEnum.Sunday:
                    break;

                case DaysEnum.Monday:
                    break;

                case DaysEnum.Tuesday:
                    break;

                case DaysEnum.Wednesday:
                    break;

                case DaysEnum.Thursday:
                    break;

                case DaysEnum.Friday:
                    break;

                case DaysEnum.Saturday:
                    break;

                default:
                    break;
            }
            var dayType = "";
            switch (choice)
            {
                case DaysEnum.Sunday:
                case DaysEnum.Saturday:
                    dayType = "Weekends";
                    break;

                case DaysEnum.Monday:
                case DaysEnum.Tuesday:
                case DaysEnum.Wednesday:
                case DaysEnum.Thursday:
                case DaysEnum.Friday:
                    dayType = "Weekends";
                    break;

                default:
                    break;
            }
        }

        private static void LoopingStatementExample()
        {
            Console.WriteLine("Enter a sentence");
            var sentence = Console.ReadLine();
            var words = sentence.Split(' ');
            string longestWord = "";

            //for loop
            for (int i = 0; i < words.Length; i++)
            {
                if (longestWord.Length < words[i].Length)
                {
                    longestWord = words[i];
                }
                Console.WriteLine(words[i]);
            }

            Console.WriteLine($"Longest Word is {longestWord}");

            //foreach loop
            longestWord = "";
            foreach (var item in words)
            {
                if (longestWord.Length < item.Length)
                {
                    longestWord = item;
                }
            }
            Console.WriteLine($"Longest Word is {longestWord}");
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

    public enum Gender
    {
        Female = 8,
        Male = 3,
        Others = 10
    }

    public enum DaysEnum
    {
        None = 0,
        Sunday = 1,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 4,
        Thursday = 5,
        Friday = 6,
        Saturday = 7,
        Weekdays = Monday | Wednesday | Thursday | Thursday | Friday,
        Weekends = Sunday | Saturday
    }
}