using System;
using System.Collections.Generic;
using Services.Contracts;

namespace ConsoleClient
{
    internal class FigureDrawer
    {
        public void DrawFigures(IEnumerable<IDrawableFigure> figures)
        {
            if (figures == null) return;

            foreach (var drawableFigure in figures)
            {
                DrawFigure(drawableFigure);
            }
        }

        private void DrawFigure(IDrawableFigure drawableFigure)
        {
            if (drawableFigure == null) return;

            var currentColor = Console.ForegroundColor;

            Console.ForegroundColor = drawableFigure.Color;

            Console.WriteLine("Figure: " + drawableFigure.GetType().Name);
            Console.WriteLine("Color: " + drawableFigure.Color);
            Console.WriteLine("X: " + drawableFigure.X);
            Console.WriteLine("Y: " + drawableFigure.Y);
            Console.WriteLine();

            Console.ForegroundColor = currentColor;
        }
    }
}