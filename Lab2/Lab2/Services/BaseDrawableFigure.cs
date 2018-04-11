using Services.Contracts;

namespace Services
{
    public abstract class BaseDrawableFigure : BaseFigure, IDrawableFigure
    {
        public string Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        protected BaseDrawableFigure() { }

        protected BaseDrawableFigure(string color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }
    }
}