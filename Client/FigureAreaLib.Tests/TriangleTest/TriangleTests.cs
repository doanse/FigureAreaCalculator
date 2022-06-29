using FigureAreaLib.Figures;
using System;
using Xunit;

namespace FigureAreaLib.Tests.TriangleTest
{
    public class TriangleTests
    {
        /// <summary>
        /// Проверка рассчета площади треугольника
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(6, 8, 10, 24)]
        [InlineData(12, 16, 20, 96)]
        public void TriangleCalculateArea_Success(double sideA, double sideB, double sideC, double expected)
        {
            // Arrange (подготовка данных для тестов)
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act (подготовка логики)
            var actual = triangle.Area;

            // Assert (проверка результатов)            
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// True если треугольник прямоугольный
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        [Theory]
        [InlineData(6, 8, 10)]
        [InlineData(12, 16, 20)]
        public void RightTriangle_Success(double sideA, double sideB, double sideC)
        {
            // Arrange (подготовка данных для тестов)
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act (подготовка логики)
            var isRightTriangle = triangle.IsRightTriangle;

            // Assert (проверка результатов)
            Assert.True(isRightTriangle);
        }

        /// <summary>
        /// Ошибка если треугольник не прямоугольный
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        [Theory]
        [InlineData(3, 3, 3)]
        [InlineData(10, 10, 10)]
        public void RightTriangle_Error(double sideA, double sideB, double sideC)
        {
            // Arrange (подготовка данных для тестов)
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act (подготовка логики)
            var isRightTriangle = triangle.IsRightTriangle;

            // Assert (проверка результатов)
            Assert.False(isRightTriangle);
        }

        /// <summary>
        /// Exception при некорректно заданных сторонах треугольника
        /// </summary>
        [Fact]
        public void TriangleSides_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(1, 7, 9));
        }
    }
}
