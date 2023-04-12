using System;

namespace RectangleEnumApp.Model
{
    internal class Rectangle
    {
        private int _width;
        private int _height;
        private ColorOption _color;
        private BorderOption _border;

        public Rectangle(int width, int height,ColorOption color)
        {
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = BorderOption.SINGLE;
        }

        public Rectangle(int width, int height, ColorOption color,BorderOption border)
        { 
            _width = ValidateSide(width);
            _height = ValidateSide(height);
            _color = color;
            _border = border;
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
            set
            {
                Width = ValidateSide(value);
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = ValidateSide(value);
            }
        }

        public ColorOption Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color =value;
            }
        }

        public BorderOption Border
        {
            get
            {
                return _border;
            }
            set
            {
                _border = value;
            }
        }
    }
}
