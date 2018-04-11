using System.Drawing;

namespace WinFormClient.Drawers
{
    internal class LineDrawer : BaseDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawLine(pen, x, y, x + 100, y);
    }
}