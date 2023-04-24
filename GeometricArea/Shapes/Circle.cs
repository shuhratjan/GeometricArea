using GeometricArea.Interfaces;
using System;

namespace GeometricArea.Shapes
{
    public class Circle : IShape
    {
        private double _Radius;
        public double Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }


        public Circle(double radius)
        {
            this._Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius,2) ;
        }

        public double GetPerimeter()
        {
            return 2 * Math.PI  * Radius;
        }
    }
}
