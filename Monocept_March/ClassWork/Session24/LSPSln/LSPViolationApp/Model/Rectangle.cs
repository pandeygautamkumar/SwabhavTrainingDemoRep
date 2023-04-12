
namespace LSPViolationApp.Model
{
    internal class Rectangle
    {
        protected int _width;
        protected int _height;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }
        public virtual void SetWidth(int pwidth)
        {
            _width = pwidth;
        }
        public virtual void SetHeight(int pheight)
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
    }
}
