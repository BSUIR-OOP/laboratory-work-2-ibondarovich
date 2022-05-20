using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using laba2New.Shapes;
using laba2New.Figures;

namespace laba2New
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Shape> dictionary;
        private Graphics graphics;
        private List<Point> pointsList;

        Shape figure;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pointsList = new List<Point>();
            dictionary = new Dictionary<string, Shape>()
            {
                {"Line", new Line() },
                {"Circle", new Circle() },
                {"Ellipse",new Ellipse() },
                {"Rectangle", new laba2New.Figures.Rectangle() },
                {"Triangle",  new Triangle() }
            };

            foreach(var item in dictionary.Keys)
            {
                comboBox1.Items.Add(item);
            }
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
            figure = dictionary.GetValueOrDefault(comboBox1.Text);
            figure.figureDrawer.DrawFigure(figure, pointsList, graphics);
            pointsList.Clear();
        }
    }
}
