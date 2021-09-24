using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp.Broadway._630AM
{
    public class Collection
    {
        public void NonGeneric()
        {
            Stack s1 = new Stack();
            s1.Push(1);
            s1.Push("");
            s1.Push(new Human());
        }

        public void Generic()
        {
            Stack<int> s1 = new Stack<int>();
            s1.Push(12);
            List<int> list = new List<int>();
            var i = list[0];
            Dictionary<int, string> dict = new Dictionary<int, string>();

            MyCollection<string> m1 = new MyCollection<string>();
            m1.Add("1");

            var res = FunctionForTuple();
            var item1 = res.Item1;
            var item2 = res.Item3;
        }

        public Tuple<int, string, float, string, int> FunctionForTuple()
        {
            var tuple = new Tuple<int, string, float, string, int>(1, "Some other string", 0, "1", 1);
            return tuple;
        }
    }

    public class MyCollection<T> : ICollection<T>
    {
        public int Count => throw new NotImplementedException();

        public bool IsReadOnly => throw new NotImplementedException();

        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}