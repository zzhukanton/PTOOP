using System;
using Services.Contracts;

namespace Services.Visitors
{
    public class FigureVisitor : IFigureVisitor
    {
        private void DrawFigure20X20Y(IDrawableFigure figure)
        {
            if (figure == null) return;

            figure.Color = "Blue";
            figure.X = 20;
            figure.Y = 20;
        }

        public void Visit(Circle figure) => DrawFigure20X20Y(figure);

        public void Visit(Dot figure) => DrawFigure20X20Y(figure);

        public void Visit(Line figure) => DrawFigure20X20Y(figure);

        public void Visit(Rectangle figure) => DrawFigure20X20Y(figure);

        public void Visit(Square figure) => DrawFigure20X20Y(figure);

        public void Visit(Triangle figure) => DrawFigure20X20Y(figure);
    }
}