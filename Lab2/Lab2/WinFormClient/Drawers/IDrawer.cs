using System.Drawing;

namespace WinFormClient.Drawers
{
    internal interface IDrawer
    {
        void Draw(Graphics g, Pen pen, int x, int y);
    }
}