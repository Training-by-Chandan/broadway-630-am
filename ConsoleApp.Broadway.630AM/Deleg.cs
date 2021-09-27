using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class Deleg
    {
        public delegate void Number(int x, int y);

        public void FunctionOne()
        {
            Number n = new Number(Add);
            n(4, 2);
            n += Subtract;
            n(4, 2);
            n += Multiple;
            n(4, 2);
            n += Divide;
            n(4, 2);
            n -= Divide;
            n(4, 2);
            n += ((a, b) =>
            {
                Console.WriteLine($"I am from anonymous function and the value are {a} and {b}");
            });
            n(4, 2);

            n = Add;
            for (int i = 1; i <= 10; i++)
            {
                n += Add;
            }
            n(4, 2);
            n -= Add;
            n -= Add;
            n -= Add;
            Console.WriteLine();
            n(4, 2);

            Console.WriteLine("Enter the value");
            var choice = Console.ReadLine();
            if (choice == "a")
            {
                n = Add;
            }
            else if (choice == "s")
            {
                n = Subtract;
            }
            else if (choice == "m")
            {
                n = Multiple;
            }
            else
            {
                n = Divide;
            }
            n(4, 2);
        }

        private void Table(int a, int b)
        {
        }

        public void Add(int a, int b)
        {
            Console.WriteLine($"Sum = {a + b}");
        }

        public void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference = {a - b}");
        }

        public void Multiple(int p, int q)
        {
            Console.WriteLine($"Product = {p * q}");
        }

        public void Divide(int a, int b)
        {
            Console.WriteLine($"Result = {a / b}");
        }
    }
}