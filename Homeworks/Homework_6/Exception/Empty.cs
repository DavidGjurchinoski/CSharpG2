using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class EmptyString : Exception
    {
        public EmptyString(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }
}
