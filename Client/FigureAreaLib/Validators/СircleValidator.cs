using System;

namespace FigureAreaLib.Validators
{
    /// <summary>
    /// Валидатор параметров круга
    /// </summary>
    internal static class СircleValidator
    {
        public static void Validate(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус круга не может быть меньше или равен 0.", nameof(radius));
            }
        }
    }
}
