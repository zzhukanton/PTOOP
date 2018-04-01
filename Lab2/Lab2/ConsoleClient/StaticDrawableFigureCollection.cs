using System;
using System.Collections;
using System.Collections.Generic;
using Services;
using Services.Contracts;
using Services.Visitors;

namespace ConsoleClient
{
    internal class StaticDrawableFigureCollection : IEnumerable<IDrawableFigure>
    {
        public IEnumerator<IDrawableFigure> GetEnumerator()
        {
            var x = 0;
            var y = 0;
            yield return new Circle(ConsoleColor.Blue, x++, y++);
            yield return new Dot(ConsoleColor.DarkGray, x++, y++);
            yield return new Line(ConsoleColor.DarkMagenta, x++, y++);
            yield return new Rectangle(ConsoleColor.Red, x++, y++);
            yield return new Square(ConsoleColor.Yellow, x++, y++);
            yield return new Triangle(ConsoleColor.Cyan, x, y);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    internal class StaticExtendableFigureCollection : IEnumerable<IDrawableFigure>
    {
        public IEnumerator<IDrawableFigure> GetEnumerator()
        {
            var staticFigures = new StaticDrawableFigureCollection();
            var visitor = new FigureVisitor();

            foreach (var staticFigure in staticFigures)
            {
                if (staticFigure == null) continue;

                staticFigure.Accept(visitor);

                yield return staticFigure;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}