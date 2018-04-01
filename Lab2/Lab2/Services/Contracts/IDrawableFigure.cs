using System;

namespace Services.Contracts
{
    public interface IDrawableFigure : IFigure
    {
        ConsoleColor Color { get; set; }

        int X { get; set; }
        int Y { get; set; }
    }
}