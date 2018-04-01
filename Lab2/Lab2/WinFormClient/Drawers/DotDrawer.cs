using System.Drawing;

namespace WinFormClient.Drawers
{
    internal class DotDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y) => graphics.DrawEllipse(pen, x, y, 2, 2);
    }
}