using Library1;

namespace ConsoleApp.Broadway._630AM
{
    public static class StrinExtension
    {
        public static string AddDot(this string s)
        {
            return s + ".";
        }
    }

    public static class RectangleExtension
    {
        public static void FunctionNew(this Rectangle r)
        {
        }
    }

    public static class IntExtension
    {
        public static int increasebynum(this int x, int num)
        {
            return x + num;
        }
    }
}