using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class Exceptions
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new Exception("Cannot be divided by 0");
            }
            if (a == 10)
            {
                throw new Exception("The first number cannot be 10");
            }
            return a / b;
        }
    }
}