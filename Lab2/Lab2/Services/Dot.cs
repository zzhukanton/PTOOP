using System;
using Services.Visitors;

namespace Services
{
    public class Dot : BaseDrawableFigure
    {
        public Dot() { }

        public Dot(ConsoleColor color, int x, int y) : base(color, x, y) { }

        public override void Accept(IFigureVisitor visitor)
        {
            visitor?.Visit(this);
        }
    }
}