using System;
using System.Collections.Generic;
using Services.Contracts;

namespace ConsoleClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IDrawableFigure> figureCollection = new FixedFigureCollection();
            var figureDrawer = new Drawer();

            Console.WriteLine("Start drawing figure list:");
            Console.WriteLine();

            figureDrawer.DrawFigures(figureCollection);

            Console.WriteLine();
            Console.WriteLine("Drawing blue figures at 20, 20:");
            Console.WriteLine();

            figureCollection = new VisitedFigureCollection();
            figureDrawer.DrawFigures(figureCollection);

            Console.ReadLine();
        }
    }
}
