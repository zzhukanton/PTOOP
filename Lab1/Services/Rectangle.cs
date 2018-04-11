using Services.Visitors;

namespace Services
{
    public class Rectangle : BaseDrawableFigure
    {
        public Rectangle() { }

        public Rectangle(string color, int x, int y) : base(color, x, y) { }

        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}