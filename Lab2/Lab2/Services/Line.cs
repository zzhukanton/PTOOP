﻿using System;
using Services.Visitors;

namespace Services
{
    public class Line : BaseDrawableFigure
    {
        public Line() { }

        public Line(ConsoleColor color, int x, int y) : base(color, x, y) { }
        
        public override void Accept(IFigureVisitor visitor) => visitor?.Visit(this);
    }
}