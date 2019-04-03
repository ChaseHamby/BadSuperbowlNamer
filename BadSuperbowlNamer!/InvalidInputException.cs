using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer_
{
    class InvalidInputException : Exception
    {
        public InvalidInputException() : base("Invalid input. Please enter a number greater than 0.")
        {
        }
    }
}
