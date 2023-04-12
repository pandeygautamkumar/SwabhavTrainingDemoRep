
namespace LSPSolutionApp.Model
{

    internal class Square : IPolygon
    {
        private int _side;
        public Square(int side)
        {
            _side = side;
        }

        public void SetSide(int pside)
        {
            _side = pside;
        }
        public int GetSide()
        {
            return _side;
        }
        public int CalculateArea()
        {
            return (_side * _side);
        }

        public int CalculatePerimeter()
        {
            return (4 * _side);
        }
    }
}
