
namespace LSPSolutionApp.Model
{

    internal class Rectangle : IPolygon
    {
        private int _width;
        private int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public void SetWidth(int pwidth)
        {
            _width = pwidth;
        }
        public void SetHeight(int pheight)
        {
            _height = pheight;
        }
        public int GetWidth()
        {
            return _width;
        }
        public int GetHeight()
        {
            return _height;
        }

        public int CalculateArea()
        {
           return (_width*_height);
        }

        public int CalculatePerimeter()
        {
            return 2 * (_width + _height);
        }
    }
}
