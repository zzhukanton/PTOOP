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

            Console.WriteLine($"Figure: {drawableFigure.GetType().Name}  Color: {drawableFigure.Color}  X:{drawableFigure.X}  Y:{drawableFigure.Y}");
            Console.WriteLine();
        }
    }
}