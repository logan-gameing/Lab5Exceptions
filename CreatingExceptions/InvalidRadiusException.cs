using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions
{
    internal class InvalidRadiusException : Exception
    {
        public InvalidRadiusException() : base() { } //base  in the base() you can put a message to return on exception
        public InvalidRadiusException(double radius) // runs if radius is negative
            : base($"Invalid radius {radius}: must be non-negative") { } 
        public InvalidRadiusException(double radius, double MAX_RADIUS) // run if radius is above max
            : base($"Invalid radius {radius}: must be between 0 and {MAX_RADIUS}") { }
    }
}
