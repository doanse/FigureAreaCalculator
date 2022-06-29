using System;

namespace FigureAreaLib.Validators
{
    /// <summary>
    /// Валидатор параметров треугольника
    /// </summary>
    internal static class TriangleValidator
    {
        public static void Validate(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна 0.", nameof(sideA));
            }

            if (sideB <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна 0.", nameof(sideB));
            }

            if (sideC <= 0)
            {
                throw new ArgumentException("Сторона треугольника не может быть меньше или равна 0.", nameof(sideC));
            }

            if (!(sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA))
            {
                throw new ArgumentException("Стороны треугольника заданы некорректно.");
            }
        }        
    }
}
