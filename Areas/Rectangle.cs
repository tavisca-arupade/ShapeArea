using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{
    public class Rectangle : IShape
    {
        double _lengthOfRectangle, _widthOfRectangle;
        double _areaOfRectangle;

        public Rectangle(double LengthOfRectangle, double WidthOfRectangle)
        {
            this._lengthOfRectangle = LengthOfRectangle;
            this._widthOfRectangle = WidthOfRectangle;
        }

        public double CalculateArea()
        {
            if(_lengthOfRectangle >= 0 ||_widthOfRectangle >= 0)
            {
                _areaOfRectangle = _lengthOfRectangle * _widthOfRectangle;
                return _areaOfRectangle;
            }
            return 0;
        }
    }


}
