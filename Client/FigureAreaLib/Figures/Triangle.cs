using FigureAreaLib.Validators;
using System;

namespace FigureAreaLib.Figures
{
    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        private readonly Lazy<bool> _isRightTriangle;

        /// <summary>
        /// Является ли треугольник прямоугольным
        /// </summary>
        public bool IsRightTriangle
        {
            get { return _isRightTriangle.Value; }
        }

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double SideA { get; private set; }

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double SideB { get; private set; }

        /// <summary>
        /// Сторона треугольника
        /// </summary>
        public double SideC { get; private set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            TriangleValidator.Validate(sideA, sideB, sideC);

            SideA = sideA;
            SideB = sideB;
            SideC = sideC;

            _isRightTriangle = new Lazy<bool>(CheckRightTriangle);
        }

        /// <summary>
        /// Рассчитывает площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected override double CalculateArea()
        {
            var semiperimeter = (SideA + SideB + SideC) / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));
        }

        /// <summary>
        /// Проверка, является ли треугольник прямоугольным
        /// </summary>
        /// <returns></returns>
        private bool CheckRightTriangle()
        {
            return (SideA * SideA + SideB * SideB == SideC * SideC) ||
                (SideA * SideA + SideC * SideC == SideB * SideB) ||
                (SideC * SideC + SideB * SideB == SideA * SideA);
        }

        public override string ToString()
        {
            return "Triangle";
        }
    }
}
