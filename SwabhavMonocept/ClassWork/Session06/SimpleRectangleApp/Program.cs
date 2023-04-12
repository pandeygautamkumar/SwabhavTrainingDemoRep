using SimpleRectangleApp.Model;
using System;

namespace SimpleRectangleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangleA;
            rectangleA = new Rectangle();

            PrintDetails(rectangleA, "Details of Rectangle A.");
            Console.WriteLine($"Width is {rectangleA.width} " +
                $"and Height is {rectangleA.height} " +
                $"and color is {rectangleA.color} and Area is {rectangleA.CalculateArea()}");

            rectangleA.width = 10;
            rectangleA.height = 20;
            rectangleA.color = "blue";

            PrintDetails(rectangleA, "Details of Rectangle A.");
            Console.WriteLine($"Rectangle A Details Will be, Width is {rectangleA.width} " +
                $"and Height is {rectangleA.height} " +
                $"and color is {rectangleA.color} and Area is {rectangleA.CalculateArea()}");


            Rectangle rectangleB;
            rectangleB = new Rectangle();

            PrintDetails(rectangleA, "Details of Rectangle A.");
            Console.WriteLine($"Rectangle B Details Will be, Width is {rectangleB.width} " +
                $"and Height is {rectangleB.height} " +
                $"and color is {rectangleB.color} and Area is {rectangleB.CalculateArea()}");

            rectangleB.color = "yellow";
            Console.WriteLine($"Color of Rectangle B is : {rectangleB.color}, hashCode is : {rectangleB.GetHashCode()}");
            Console.WriteLine($"Color of Rectangle A is : {rectangleA.color}, hashCode is : {rectangleA.GetHashCode()}");
        }

        static void PrintDetails(Rectangle rectangle,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Width is {rectangle.width} "+
                $"Height is {rectangle.height} "+
                $"Color is {rectangle.color} "+
                $"Area is {rectangle.CalculateArea()}");
        }
    }
}
