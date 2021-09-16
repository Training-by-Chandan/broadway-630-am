using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library1;

namespace ConsoleApp.Broadway._630AM
{
    public class Circle : IShape
    {
        private double radius;

        private double area;
        public double AreaVal { get { return area; } }

        private double perimeter;
        public double PerimeterVal => perimeter;

        public void Area()
        {
            area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"Area => {area}");
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the radius");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Perimeter()
        {
            perimeter = 2 * Math.PI * radius;
            Console.WriteLine($"Perimeter => {perimeter}");
        }
    }

    public interface IPost
    {
        void post(string post);
    }

    public class Facebook : IPost
    {
        public void post(string post)
        {
            throw new NotImplementedException();
        }
    }

    public class Linkedin : IPost
    {
        public void post(string post)
        {
            throw new NotImplementedException();
        }
    }

    public class Twitter : IPost
    {
        public void post(string post)
        {
            throw new NotImplementedException();
        }
    }

    public class TestSocialMedia
    {
        private void Test()
        {
            var post = Console.ReadLine();

            IPost[] socialmedia = new IPost[] { new Facebook(), new Linkedin(), new Twitter() };

            foreach (var item in socialmedia)
            {
                item.post(post);
            }
        }
    }
}