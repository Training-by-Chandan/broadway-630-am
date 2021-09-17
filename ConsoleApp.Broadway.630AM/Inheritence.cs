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

        public virtual void Eat()
        {
            Console.WriteLine("I am living thing and I can eat");
        }

        public override string ToString()
        {
            return "An object of Living Thing";
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

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am from animal and I eat like animal");
        }

        public override string ToString()
        {
            return "I am object of Animal";
        }
    }

    public class Plant : LivingThings
    {
        public Plant() : base(10)
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am from plant and I eat like plant");
        }
    }

    public class Human : Animal
    {
        public Human()
        {
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("I am human and I eat delicious food");
        }

        public void Run()
        {
        }
    }

    public class Man : Human
    {
        public void Eat()
        {
            base.Eat();
            Console.WriteLine("I am man and I eat like human");
        }
    }

    public class TestingClass : Class1
    {
        private void TestFunction()
        {
        }
    }

    public class RectangleNew : Rectangle
    {
        public void FunctionOne()
        {
        }
    }
}