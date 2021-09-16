using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library1
{
    public class Class1
    {
        public int publicVal = 10;
        protected int protectedval = 10;
        private int privateVal = 10;
        internal int internalInt = 10;
        protected internal int protectedInternalVal = 10;
    }

    public class Class2 : Class1
    {
    }

    public class TestClass
    {
        private void TestFunction()
        {
            Class1 c1 = new Class1();
        }
    }

    public interface IArea
    {
        double AreaVal { get; }

        void Area();
    }

    public interface IPerimeter
    {
        double PerimeterVal { get; }

        void Perimeter();
    }

    public interface IGetInput
    {
        void GetInput();
    }

    public interface IShape : IArea, IPerimeter, IGetInput
    {
    }

    public class Rectangle : IShape
    {
        private double length;
        public double Length { get { return length; } }
        private double breadth;
        public double Breadth { get { return breadth; } }
        private double area;
        public double AreaVal { get { return area; } }

        private double perimeter;
        public double PerimeterVal { get { return perimeter; } }

        public void Area()
        {
            area = length * breadth;
            Console.WriteLine($"Area => {area}");
        }

        public void Perimeter()
        {
            perimeter = 2 * (length + breadth);
            Console.WriteLine($"Perimeter => {perimeter}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            breadth = Convert.ToDouble(Console.ReadLine());
        }
    }

    public class Square : IShape
    {
        private double length;
        public double Length { get { return length; } }

        private double area;
        public double AreaVal { get { return area; } }

        private double perimeter;
        public double PerimeterVal { get { return perimeter; } }

        public void Area()
        {
            area = Math.Pow(length, 2);
            Console.WriteLine($"Area => {area}");
        }

        public void Perimeter()
        {
            perimeter = 4 * length;
            Console.WriteLine($"Perimeter => {perimeter}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
        }
    }
}