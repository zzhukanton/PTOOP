﻿using System;
using Services.Contracts;

namespace Services.Visitors
{
    public class FigureVisitor : IFigureVisitor
    {
        private void DrawFigureOn20X20Y(IDrawableFigure figure)
        {
            if (figure == null) return;

            figure.Color = ConsoleColor.DarkBlue;
            figure.X = 20;
            figure.Y = 20;
        }

        public void Visit(Circle figure) => DrawFigureOn20X20Y(figure);

        public void Visit(Dot figure) => DrawFigureOn20X20Y(figure);

        public void Visit(Line figure) => DrawFigureOn20X20Y(figure);

        public void Visit(Rectangle figure) => DrawFigureOn20X20Y(figure);

        public void Visit(Square figure) => DrawFigureOn20X20Y(figure);

        public void Visit(Triangle figure) => DrawFigureOn20X20Y(figure);
    }
}