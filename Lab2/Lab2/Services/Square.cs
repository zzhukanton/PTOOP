using Services.Visitors;

namespace Services
{
    public class Square : BaseDrawableFigure
    {
        public Square() { }

        public Square(string color, int x, int y) : base(color, x, y) { }

        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}