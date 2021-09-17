using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    //no object is created
    public abstract class ShapeAbs
    {
        public double AreaVal { get; set; }
        public double PerimeterVal { get; set; }

        public void Area()
        {
            Console.WriteLine($"Area => {AreaVal}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter => {PerimeterVal}");
        }

        public abstract void GetInput();
    }

    public class RectangleAbs : ShapeAbs
    {
        private double length;
        public double Length { get { return length; } }
        private double breadth;
        public double Breadth { get { return breadth; } }

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth");
            breadth = Convert.ToDouble(Console.ReadLine());

            AreaVal = length * breadth;
            PerimeterVal = 2 * (length + breadth);
        }
    }

    public class SquareAbs : ShapeAbs
    {
        private double length;
        public double Length { get { return length; } }

        public override void GetInput()
        {
            Console.WriteLine("Enter the Length");
            length = Convert.ToDouble(Console.ReadLine());

            AreaVal = length * length;
            PerimeterVal = 4 * length;
        }
    }
}