using System;
using Services.Contracts;

namespace Services
{
    public abstract class BaseDrawableFigure : BaseFigure, IDrawableFigure
    {
        public ConsoleColor Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        protected BaseDrawableFigure() { }

        protected BaseDrawableFigure(ConsoleColor color, int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }
    }
}