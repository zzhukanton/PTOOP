using System.Drawing;

namespace WinFormClient.Drawers
{
    internal interface IDrawer
    {
        void Draw(Graphics graphics, Pen pen, int x, int y);
    }
}