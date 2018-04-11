namespace Services.Contracts
{
    public interface IDrawableFigure : IFigure
    {
        string Color { get; set; }

        int X { get; set; }
        int Y { get; set; }
    }
}