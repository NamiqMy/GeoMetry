using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public static class GeometryHelper
    {
        public static double CalculateRectangleArea(double length, double width)
        {
            return length * width;
        }

        public static double CalculateTriangleArea(double baselength, double height)
        {
            return baselength * height / 2;
        }
        public static double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }

        
    }
}
