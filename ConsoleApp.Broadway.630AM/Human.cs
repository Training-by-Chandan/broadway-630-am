using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM.ABC
{
    public class Human
    {
        public Human()
        {
            Console.WriteLine("A new human is born.");
        }

        private int _eyes = 2;
        private int _hands = 2;
        private int _legs = 2;
        private double _height = 1.1;
        private double _weight = 5.0;

        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                _weight = value;
            }
        }

        public void Eat()
        {
            _weight = _weight + .1;
        }
    }
}