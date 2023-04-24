using GeometricArea.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricArea.Shapes
{
    public class Triangle : IShape
    {
        private double _A;
        private double _B;
        private double _C;
        /// <summary>
        /// Это прямоугольный треугольник
        /// </summary>
        private bool _IsRight;
        public double A { get => _A; set => _A = value; }
        public double B { get => _B; set => _B = value; }
        public double C { get => _C; set => _C = value; }
        /// <summary>
        /// Является ли треугольник прямоугольным?
        /// </summary>
        public bool IsRight { get => _IsRight; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;

            _IsRight = IsRightTriangle();
        }
        /// <summary>
        /// Опрелеляет является ли треугольник прямоугольным
        /// </summary>
        /// <returns>
        /// True - если это прямоугольник, иначе False
        /// </returns>
        private bool IsRightTriangle()
        {
            double gipotenuza = Math.Max(A, Math.Max(B, C));
            double first, second;
            if (gipotenuza == A)
            {
                first = B;
                second = C;
            }
            else if (gipotenuza == B)
            {
                first = A;
                second = C;
            }
            else
            {
                first = A;
                second = B;
            }

            return Math.Pow(gipotenuza, 2) == Math.Pow(2, first) + Math.Pow(2, second);
        }

        public double GetArea()
        {

            double p = GetPerimeter() / 2;
            double area = 0;
            area = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            return area;
        }

        public double GetPerimeter()
        {
            return A + B + C;
        }

        /// <summary>
        /// Каждая сторона треугольника должен быть меньше суммы двух других сторон
        /// </summary>
        /// <returns></returns>
        private bool IsCanBeTriangle()
        {
            bool isTriangle = true;

            if (A + B < C) isTriangle = false;
            else if (A + C < B) isTriangle = false;
            else if (B + C < A) isTriangle = false;

            return isTriangle;
        }
    }
}
