using System.Drawing;

namespace WinFormClient.Drawers
{
    internal abstract class BaseDrawer : IDrawer 
    {
        public abstract void Draw(Graphics g, Pen pen, int x, int y);
    }
}
