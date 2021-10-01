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
            else if (b == 10)
            {
                throw new TestException("Throwing test exception");
            }

            if (a == 10)
            {
                throw new Exception("The first number cannot be 10");
            }
            else if (a == 0)
            {
                throw new CustomException("Custom exception sent");
            }
            return a / b;
        }
    }

    [Serializable]
    public class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }

        public CustomException(string message, Exception inner) : base(message, inner)
        {
        }

        protected CustomException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    [Serializable]
    public class TestException : Exception
    {
        public TestException()
        {
        }

        public TestException(string message) : base(message)
        {
        }

        public TestException(string message, Exception inner) : base(message, inner)
        {
        }

        protected TestException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}