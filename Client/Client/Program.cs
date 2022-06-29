using FigureAreaLib;
using FigureAreaLib.Figures;
using System;
using System.Collections.Generic;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Figure> figures = new List<Figure>
                {
                    new Сircle(1),
                    new Triangle(12, 16, 20)
                };

                foreach (var figure in figures)
                {
                    Console.WriteLine($"Площадь {figure} = {figure.Area}");

                    var triangle = figure as Triangle;

                    if (triangle != null)
                    {
                        Console.WriteLine($"isRightTriangle = {triangle.IsRightTriangle}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
