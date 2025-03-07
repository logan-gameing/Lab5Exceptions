using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CreatingExceptions
{
    public class Circle
    {

        private double radius;
        private const double MAX_RADIUS = 20;

        public Circle(double newRadius)
        {
            //Circle constructor that either sets radius or throws and exception if newRadius doesnt match parameters
            if (newRadius < radius)
            { throw new InvalidRadiusException(newRadius); }
            else if (MAX_RADIUS < newRadius)
            { throw new InvalidRadiusException(newRadius, MAX_RADIUS); }
            else { radius = newRadius; }
           }

        public override string ToString()
        {
            return $"Circle[radius={radius}]";
        }

    }
}
