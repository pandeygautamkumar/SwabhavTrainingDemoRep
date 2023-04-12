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
            if (pColor == "red" || pColor == "blue" || pColor == "green")
                _color = pColor;
            else
                _color = "red";
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetWidth(int pWidth)
        {
            if (pWidth > 500)
                _width = 500;
            else if (pWidth < 1)
                _width = 1;
            else
                _width = pWidth;
        }
        
        public int GetWidth()
        {
            return _width;
        }
        public void SetHeight(int pHeight)
        {
            if (pHeight > 100)
                _height = 100;
            else if (pHeight < 1)
                _height = 1;
            else
                _height = pHeight;
        }

        public int GetHeight()
        {
            return _height;
        }
    }
}
