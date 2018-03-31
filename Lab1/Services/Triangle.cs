using System;
using Services.Visitors;

namespace Services
{
    public class Triangle : BaseDrawableFigure
    {
        public Triangle()
        {
        }

        public Triangle(ConsoleColor color, int coordinateX, int coordinateY) : base(color, coordinateX, coordinateY)
        {
        }

        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}