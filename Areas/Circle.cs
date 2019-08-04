using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{

    public class Circle : IShape
    {
        const double _pi = 3.14;
        double _radiusOfCircle, _areaOfCircle;

        public Circle(double RadiusOfCircle)
        {
            this._radiusOfCircle = RadiusOfCircle;
        }

        public double CalculateArea()
        {
            if(_radiusOfCircle >= 0)
            {
                _areaOfCircle = _pi * _radiusOfCircle * _radiusOfCircle;
                return _areaOfCircle;
            }
            return 0;
        }
    }

}
