using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{
    public class Trianlge : IShape
    {
        double _baseOfTrianlge, _heightOfTriangle;
        double _areaOfTriangle;
        double _side1, _side2, _side3;

        public Trianlge(double BaseOfTrianlge, double HeightOfTriangle)
        {
            this._baseOfTrianlge = BaseOfTrianlge;
            this._heightOfTriangle = HeightOfTriangle;
        }

        public Trianlge(double Side1, double Side2,double Side3)
        {
            this._side1 = Side1;
            this._side2 = Side2;
            this._side3 = Side3;
        }

        public double CalculateArea()
        {
            if(_baseOfTrianlge >= 0 || _heightOfTriangle >= 0)
            {
                _areaOfTriangle = 0.5 * _heightOfTriangle * _baseOfTrianlge;
                return _areaOfTriangle;
            }
            return 0;
           
        }
    }
}
