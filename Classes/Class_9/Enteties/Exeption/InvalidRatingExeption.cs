using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Enteties.Exeption
{
    public class InvalidRatingExeption : Exception
    {
        public InvalidRatingExeption(string message) : base(message)
        {
        }
    }
}
