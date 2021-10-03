using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergingInterval
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var scenarioOne = new List<Interval>();
            scenarioOne.Add(new Interval(2, 4));
            scenarioOne.Add(new Interval(30, 55));
            scenarioOne.Add(new Interval(3, 15));
            scenarioOne.Add(new Interval(21, 35));
            var output = Function(scenarioOne);
            foreach (var item in output)
            {
                Console.Write($"[{item.Lower},{item.Upper}]");
            }

            Console.ReadLine();
        }

        private static Stack<Interval> Function(List<Interval> intervals)
        {
            var stack = new Stack<Interval>();
            if (intervals.Count == 0)
                return stack;

            intervals = intervals.OrderBy(p => p.Lower).ToList();
            stack.Push(intervals[0]);

            for (int i = 1; i < intervals.Count; i++)
            {
                var tempItem = stack.Peek();
                if (tempItem.Upper > intervals[i].Lower && tempItem.Upper < intervals[i].Upper)
                {
                    tempItem.Upper = intervals[i].Upper;
                }
                else if (tempItem.Upper < intervals[i].Lower)
                {
                    stack.Push(intervals[i]);
                }
            }

            return stack;
        }
    }

    internal class Interval
    {
        public Interval(int lower, int upper)
        {
            this.Lower = lower;
            this.Upper = upper;
        }

        public int Lower { get; set; }
        public int Upper { get; set; }
    }
}