using System;

namespace FigureAreaLib
{
    /// <summary>
    /// Абстрактный класс геометрической фигуры
    /// </summary>
    public abstract class Figure
    {
        private readonly Lazy<double> _area;

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Area 
        { 
            get 
            { 
                return _area.Value; 
            } 
        }

        protected Figure()
        {
            _area = new Lazy<double>(CalculateArea);
        }

        /// <summary>
        /// Рассчитывает площадь фигуры
        /// </summary>
        /// <returns></returns>
        protected abstract double CalculateArea();
    }
}
