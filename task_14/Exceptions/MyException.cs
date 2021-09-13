using System;

namespace Exceptions
{
    public class MyException : Exception
    {
        public MyException(string message) : base(message)
        {

        }
    }
}
