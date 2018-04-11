using Services.Visitors;

namespace Services
{
    public class Polygon : BaseDrawableFigure
    {
        public Polygon() { }

        public Polygon(string color, int x, int y) : base(color, x, y) { }

        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}