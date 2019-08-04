using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{
    public class Square : IShape
    {
        const double _defaultValue = 1.0;
        double _sideOfSquare = _defaultValue;
        double _areaOfSquare = _defaultValue;

        public Square(double SideOfSquare)
        {
            this._sideOfSquare = SideOfSquare;
        }
        public double CalculateArea()
        {
            if(_sideOfSquare >= 0)
            {
                _areaOfSquare = _sideOfSquare * _sideOfSquare;
                return _areaOfSquare;
            }
            return 0;
        }
    }

}
