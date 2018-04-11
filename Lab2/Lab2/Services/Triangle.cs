using Services.Visitors;

namespace Services
{
    public class Triangle : BaseDrawableFigure
    {
        public Triangle() { }

        public Triangle(string color, int x, int y) : base(color, x, y) { }

        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}