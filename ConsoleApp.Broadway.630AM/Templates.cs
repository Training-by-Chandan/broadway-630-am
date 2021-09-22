using Library1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class Templates<T1, T2>
        where T1 : IShape
        where T2 : struct
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T2 Item3 { get; set; }
        public T1 Item4 { get; set; }
        public T1 Item5 { get; set; }

        public T1 FunctionOne(T1 item1, T2 item2)
        {
            return item1;
        }

        public void FunctionTwo<TItem1, TItem2, TItem3>(TItem1 i1, TItem2 i2, TItem3 i3)
            where TItem1 : class
        {
            //do some stuffs
        }
    }
}