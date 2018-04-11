using System.Drawing;

namespace WinFormClient.Drawers
{
    internal class RectangleDrawer : BaseDrawer
    {
        public override void Draw(Graphics g, Pen pen, int x, int y) => g.DrawRectangle(pen, x, y, 50, 100);
    }
}