using MultiCastingDelegates.Model;

namespace MultiCastingDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(30, 40);

            Rectangle.RectangleDelegate rectangleDelegate = new Rectangle.RectangleDelegate(rectangle.Area);
            rectangleDelegate += rectangle.Perimeter;
            rectangleDelegate += rectangle.AddBothside;
            
            rectangleDelegate();
        }
    }
}