using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class PassBy
    {
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
        }
    }
}