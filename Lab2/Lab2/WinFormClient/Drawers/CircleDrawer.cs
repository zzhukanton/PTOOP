using System.Drawing;

namespace WinFormClient.Drawers
{
    internal class CircleDrawer : BaseDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawEllipse(pen, x, y, 50, 50);
    }
}