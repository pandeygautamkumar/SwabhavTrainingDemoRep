using RectangleApp.Model;
using System;

namespace RectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle small;
            small = new Rectangle();
            small.height = 5;
            small.width = 20;
            Console.WriteLine("Width of Small Rectangle will be : {0} ", small.width);
            Console.WriteLine("Height of Small Rectangle Will be : {0}", small.height);
            Console.WriteLine("Area of Small Rectaangle Will be : {0}",small.CalculateArea());

            Rectangle big=new Rectangle();
            small.height = 50;
            small.width = 100;
            Console.WriteLine("Width of Big Rectangle will be : {0} ", small.width);
            Console.WriteLine("Height of Big Rectangle Will be : {0}", small.height);
            Console.WriteLine("Area of Big Rectaangle Will be : {0}", small.CalculateArea());

        }
    }
}
