using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormClient.Drawers;

namespace WinFormClient
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private Graphics g;
        private Color CurrentColor = Color.Red;

        private Pen Pen { get { return new Pen(CurrentColor, 2F); } }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDrawers();

            if (lbxTools.Items.Count > 0)
            {
                lbxTools.SelectedIndex = 0;
            }
        }

        private void InitializeDrawers()
        {
            lbxTools.Items.Add(new ComboboxItem() {Text = "Circle", Value = new CircleDrawer()});
            lbxTools.Items.Add(new ComboboxItem() {Text = "Dot", Value = new DotDrawer()});
            lbxTools.Items.Add(new ComboboxItem() {Text = "Line", Value = new LineDrawer()});
            lbxTools.Items.Add(new ComboboxItem() {Text = "Rectangle", Value = new RectangleDrawer()});
            lbxTools.Items.Add(new ComboboxItem() {Text = "Square", Value = new SquareDrawer()});
            lbxTools.Items.Add(new ComboboxItem() {Text = "Triangle", Value = new TriangleDrawer()});
        }

        private void button1_Click(object sender, EventArgs e) => pictureBox1.Refresh();

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            g.DrawLine(Pen, 250, 50, 400, 200);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
            var mouseEventArgs = e as MouseEventArgs;

            if (mouseEventArgs == null) return;

            var selectedDrawer = (lbxTools.SelectedItem as ComboboxItem)?.Value as IDrawer;

            selectedDrawer?.Draw(g, Pen, mouseEventArgs.X, mouseEventArgs.Y);
        }
    }
}
