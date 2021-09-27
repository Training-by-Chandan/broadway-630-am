using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class PassBy
    {
        public const double test = 1.23;
        public readonly double testnew = 1.23;

        public PassBy()
        {
            testnew = 1.25;
            //test = 1.25;
        }

        private void Test()
        {
            //test = 1.24;
            //testnew = 1.24;
        }

        public static int Value(int i, int j)
        {
            i++;
            j++;
            return i + j;
        }

        public static void Refernece(ref int i, ref int j)
        {
            i++;
            j++;
        }

        public static void Out(int i, int j, out int result)
        {
            i++;
            j++;
            result = i + j;
            //int.TryParse("a", out result);
        }
    }
}