using System;
using System.Text;

namespace SimpleCircleApp.Model
{
    internal class Circle
    {
        private float _radius;
        private string _color;
        private string _borderStyle;

        public void SetRadius(float pRadius)
        {
            if (pRadius > 60.00f)
                _radius = 60f;
            else
                _radius = pRadius;
        }

        public float GetRedius()
        {
            return _radius;
        }

        public void SetColor(string pColor)
        {
            if (pColor.ToUpper() == "RED" || pColor.ToUpper() == "BLUE" || pColor.ToUpper() == "GREEN" || pColor.ToUpper() == "YELLOW")
                _color = pColor;
            else
                _color = "RED";
        }

        public string GetColor()
        {
            return _color;
        }

        public void SetBorderStyle(string pBorderStyle)
        {
            pBorderStyle = pBorderStyle.ToUpper();
            if (pBorderStyle == "DOTTED" || pBorderStyle == "SINGLE LINE" || pBorderStyle == "DOUBLE LINE")
                _borderStyle = pBorderStyle;
            else
                _borderStyle = "SINGLE LINE";
        }

        public string GetBorderStyle()
        {
            return _borderStyle;
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
