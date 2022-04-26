using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace laba2
{
    public partial class Form1 : Form
    {
        List<System.Drawing.Point> pointsList;
        Graphics graphics;
        public Form1()
        {
            InitializeComponent();
            pointsList = new List<System.Drawing.Point>();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            graphics = CreateGraphics();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            graphics.Clear(BackColor);
            pointsList.Clear();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pointsList.Add(e.Location);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            FigureList figureList = new FigureList(pointsList, graphics);
            figureList.DrawFigure(comboBox1.SelectedIndex);
            pointsList.Clear();
        }
    }
}
