using Services.Visitors;

namespace Services
{
    public class Circle : BaseDrawableFigure
    {
        public Circle() { }

        public Circle(string color, int x, int y) : base(color, x, y) { }
        
        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}