using SimpleCircleApp.Model;
using System;

namespace SimpleCircleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circleA = new Circle();
            circleA.SetRadius(23.90f);
            circleA.SetColor("abcd");
            circleA.SetBorderStyle("none");
            PrintDetails(circleA,"Details of Circle A");

            Circle circleB = new Circle();
            circleB.SetRadius(32.90f);
            circleB.SetColor("Yellow");
            circleB.SetBorderStyle("dotted");
            PrintDetails(circleB, "Details of Circle B");

        }

        static void PrintDetails(Circle circle,string description)
        {
            Console.WriteLine(description.ToUpper());
            Console.WriteLine($"Redius of Circle : {circle.GetRedius()}");
            Console.WriteLine($"Color of Circle : {circle.GetColor()}");
            Console.WriteLine($"BorderStyle of Circle : {circle.GetBorderStyle()}");
            Console.WriteLine($"Area of Circle : {circle.CalculateArea()}");
            Console.WriteLine($"Circumference of Circle : {circle.CalculateCircumference()}");

            Console.WriteLine();
        }
    }
}
