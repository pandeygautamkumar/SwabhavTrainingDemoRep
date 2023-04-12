using System;
using System.Text;

namespace RectanglePropertiesApp.Model
{
    internal class Rectangle
    {
        private readonly int _width;
        private readonly int _height;
        private string _color;

        public Rectangle(int width, int height, string color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = ValidateColor(color);
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

        private string ValidateColor(string pColor)
        {
            pColor = pColor.ToUpper();
            if (pColor == "RED" || pColor == "BLUE" || pColor == "GREEN")
                _color = pColor;
            else
                _color = "RED";
            return pColor;
        }
        public int CalculateArea()
        {
            return _width * _height;
        }

        public int Width
        {
            get
            {
                return _width;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }   
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = ValidateColor(value);
            }
        }
    }
}
