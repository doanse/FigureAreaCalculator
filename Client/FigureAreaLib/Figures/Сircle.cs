using FigureAreaLib.Validators;
using System;

namespace FigureAreaLib.Figures
{
    /// <summary>
    /// Круг
    /// </summary>
    public class Сircle : Figure
    {
        private double Radius { get; set; }

        public Сircle(double radius)
        {
            СircleValidator.Validate(radius);

            Radius = radius;
        }

        /// <summary>
        /// Рассчитывает площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2d);
        }

        public override string ToString()
        {
            return "Сircle";
        }
    }
}
