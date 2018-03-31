using Services.Contracts;
using Services.Visitors;

namespace Services
{
    public abstract class BaseFigure : IFigure
    {
        public abstract void Accept(IFigureVisitor visitor);
    }
}