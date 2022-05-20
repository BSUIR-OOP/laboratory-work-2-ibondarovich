using System.Collections.Generic;
using System.Drawing;
using laba2New.Shapes;

namespace laba2New.Drawing
{
    public class CurveDrawer : FigureDrawer
    {
        public override void DrawFigure(Shape figure, List<Point> pointList, Graphics graphics)
        {
            Point[]list = figure.AddСoordinates(pointList);
            graphics.DrawEllipse(pen, list[0].X, list[0].Y, list[1].X, list[1].Y);
        }
    }
}