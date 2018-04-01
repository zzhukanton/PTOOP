using System.Drawing;

namespace WinFormClient.Drawers
{
    internal abstract class BaseDrawer : IDrawer 
    {
        public abstract void Draw(Graphics graphics, Pen pen, int x, int y);
    }
}
