using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Broadway._630AM
{
    public class CustomStack
    {
        public CustomStack()
        {
            maxSize = 5;
            container = new int[maxSize];
        }
        public CustomStack(int maxItem)
        {
            maxSize = maxItem;
            container = new int[maxSize];
        }
        private int maxSize = 0;
        private int[] container = new int[0];
        private int counter = 0;

        public void Push(int item)
        {
            if (counter < maxSize)
            {
                container[counter] = item;
                counter++;
            }
            else
            {
                Console.WriteLine("Stack is full");
                Console.WriteLine("-----------------------");
            }
        }

        public void Pop()
        {
            if (counter > 0)
            {
                container[counter - 1] = 0;
                counter--;
            }
            else
            {
                Console.WriteLine("Stack is empty");
                Console.WriteLine("-----------------------");
            }
        }

        public void DisplayAll()
        {
            for (int i = counter - 1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
            Console.WriteLine("-----------------------");
        }

        public void Peek()
        {
            Console.WriteLine($"Item at top is {container[counter - 1]}");
            Console.WriteLine("-----------------------");
        }
    }

    public class CustomStackV2
    {
        private int[] container = new int[0];

        public void Push(int item)
        {
            Array.Resize(ref container, container.Length + 1);
            var index = container.Length - 1;
            container[index] = item;
        }

        public void Pop()
        {
            if (container.Length>0)
            {
                Array.Resize(ref container, container.Length - 1);
            }
        }

        public void DisplayAll()
        {
            for (int i = container.Length-1; i >= 0; i--)
            {
                Console.WriteLine(container[i]);
            }
            Console.WriteLine("-----------------------");

        }

        public void Peek()
        {
            Console.WriteLine($"Item at top of the stack is {container[container.Length - 1]}");
            Console.WriteLine("-----------------------");

        }
    }
}