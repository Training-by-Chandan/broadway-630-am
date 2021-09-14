using Library1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    //one class can inherit only one class
    public class LivingThings
    {
        //public LivingThings()
        //{
        //}
        public int I = 10;

        private int J = 10;

        protected int K = 10;

        public LivingThings(int i)
        {
            //do something here
        }

        public LivingThings(string s)
        {
            //we will do some code here later on
        }

        public void Respire()
        {
            Console.WriteLine("I am living thing and I can resipr ");
        }

        public void Eat()
        {
            Console.WriteLine("I am living thing and I can eat");
        }
    }

    public class Animal : LivingThings
    {
        public Animal() : base(10)
        {
        }

        public Animal(int i) : base(i)
        {
        }

        public Animal(string s) : base(s)
        {
        }

        public void Test()
        {
            I = 30;

            K = 30;
        }
    }

    public class Plant : LivingThings
    {
        public Plant() : base(10)
        {
        }
    }

    public class Human : Animal
    {
        public Human()
        {
        }
    }

    public class TestingClass : Class1
    {
        private void TestFunction()
        {
        }
    }
}