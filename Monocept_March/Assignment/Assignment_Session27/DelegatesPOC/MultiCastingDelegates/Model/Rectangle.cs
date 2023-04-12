
namespace MultiCastingDelegates.Model
{
    internal class Rectangle
    {
        private double _height;
        private double _width;
        public Rectangle(double height, double width)
        {
            _height = height;
            _width = width;
        }
        public delegate void RectangleDelegate();
        public void Area()
        {
            Console.WriteLine("Area of Rectangle : " + (_width * _height));
        }
        public void Perimeter()
        {
            Console.WriteLine("Perimeter of Rectangle : " + (2 * (_width + _height)));
        }
        public void AddBothside()
        {
            Console.WriteLine("Addition of Both side(Height,width) Of Rectangle: " + (_width + _height));
        }
    }
}
