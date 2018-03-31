using Services.Visitors;

namespace Services.Contracts
{
    public interface IFigure
    {
        void Accept(IFigureVisitor visitor);
    }
}
