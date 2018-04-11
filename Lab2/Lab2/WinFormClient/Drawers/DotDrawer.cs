using System.Drawing;

namespace WinFormClient.Drawers
{
    internal class DotDrawer : BaseDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawEllipse(pen, x, y, 2, 2);
    }
}