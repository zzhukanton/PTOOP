namespace Services.Visitors
{
    public interface IFigureVisitor
    {
        void Visit(Circle figure);
        void Visit(Dot figure);
        void Visit(Line figure);
        void Visit(Rectangle figure);
        void Visit(Square figure);
        void Visit(Triangle figure);
    }
}