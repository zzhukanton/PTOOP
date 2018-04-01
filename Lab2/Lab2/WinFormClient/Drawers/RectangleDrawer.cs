using System.Drawing;

namespace WinFormClient.Drawers
{
    internal class RectangleDrawer : BaseDrawer
    {
        public override void Draw(Graphics graphics, Pen pen, int x, int y) => graphics.DrawRectangle(pen, x, y, 50, 100);
    }
}