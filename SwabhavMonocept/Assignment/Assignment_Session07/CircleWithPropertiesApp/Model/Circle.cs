using System;
using System.Text;

namespace CircleWithPropertiesApp.Model
{
    internal class Circle
    {
        private float _radius;
        private string _color;
        private string _borderStyle;

        public Circle(float radius, string color, string borderStyle)
        {
            _radius = radius;
            _color = color;
            _borderStyle = borderStyle;
        }

        private string ValidateColor(string pColor)
        {
            pColor = pColor.ToUpper();
            if (pColor.ToUpper() == "RED" || pColor.ToUpper() == "BLUE" || pColor.ToUpper() == "GREEN" || pColor.ToUpper() == "YELLOW")
                return pColor;
            else
                return "RED";
        }
        private string ValidateBorderStyle(string pBorderStyle)
        {
            pBorderStyle = pBorderStyle.ToUpper();
            if (pBorderStyle == "DOTTED" || pBorderStyle == "SINGLE LINE" || pBorderStyle == "DOUBLE LINE")
                return pBorderStyle;
            else
                return "SINGLE LINE";
        }

        private float ValidateRadius(float pRadius)
        {
            if (pRadius > 60.00f)
                return 60f;
            else
                return pRadius;
        }
        public float Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = ValidateRadius(value);
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
        public string BorderStyle
        {
            get
            {
                return _borderStyle;
            }
            set
            {
                _borderStyle = ValidateBorderStyle(value);
            }
        }
        public double CalculateArea()
        {
            return (3.14 * _radius * _radius);
        }
        public double CalculateCircumference()
        {
            return (2 * 3.14 * _radius);
        }
    }
}
