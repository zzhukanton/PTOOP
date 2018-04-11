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
            yield return new Circle("White", 0, 10);
            yield return new Dot("Black", 10, 20);
            yield return new Line("Red", 70, 90);
            yield return new Rectangle("Green", 120, 120);
            yield return new Square("Yellow", 130, 140);
            yield return new Triangle("Azure", 200, 200);
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
                if (staticFigure == null)
                {
                    continue;
                }

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