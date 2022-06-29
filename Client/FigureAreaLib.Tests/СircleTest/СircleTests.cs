using FigureAreaLib.Figures;
using System;
using Xunit;

namespace FigureAreaLib.Tests.СircleTest
{
    public class СircleTests
    {
        /// <summary>
        /// Проверка рассчета площади круга
        /// </summary>
        [Fact]
        public void СircleCalculateArea_Success()
        {
            // Arrange (подготовка данных для тестов)
            var circle = new Сircle(1);

            // Act (подготовка логики)
            var actual = circle.Area;

            // Assert (проверка результатов)
            var expected = 3.1415926535897931;
            Assert.Equal(expected, actual);
        }

        /// <summary>
        /// Exception при некорректно заданном радиусе круга
        /// </summary>
        [Fact]
        public void CircleRadius_Exception()
        {
            Assert.Throws<ArgumentException>(() => new Сircle(0));
        }
    }
}
