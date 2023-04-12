using System;
using System.Text;

namespace SimpleRectangleApp.Model
{
    internal class Rectangle
    {
        public int width;
        public int height;
        public string color;

        public int CalculateArea()
        {
            int area = width * height;
            return area;
        }
    }
}
