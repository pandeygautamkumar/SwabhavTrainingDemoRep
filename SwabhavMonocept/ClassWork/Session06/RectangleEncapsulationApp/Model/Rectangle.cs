using System;
using System.Runtime.InteropServices;
using System.Text;

namespace RectangleEncapsulationApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private string _color;

        public int CalculateArea()
        {
            return _width * _height;
        }

        public void SetColor(string pColor)
        {
            pColor = pColor.ToUpper();
            if (pColor== "RED" || pColor== "BLUE" || pColor == "GREEN")
                _color = pColor;
            else
                _color = "RED";
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetWidth(int pWidth)
        {
            _width = ValidateSide(pWidth);
        }
        
        public int GetWidth()
        {
            return _width;
        }
        public void SetHeight(int pHeight)
        {
            _height=ValidateSide(pHeight);
        }
        private int ValidateSide(int side)
        {
            if (side > 100)
                return 100;
            else if (side < 1)
                return 1;
            else
                return side;
        }
        public int GetHeight()
        {
            return _height;
        }
    }
}
