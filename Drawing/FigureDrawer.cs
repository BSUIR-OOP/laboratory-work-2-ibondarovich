using laba2New.Shapes;
using System.Drawing;
using System.Collections.Generic;


namespace laba2New
{
    public abstract class FigureDrawer
    {
        protected Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);
        public abstract void DrawFigure(Shape figure, List<Point> pointList, Graphics graphics);
    }
}