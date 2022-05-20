using System.Collections.Generic;
using System.Drawing;
using laba2New.Shapes;
using System;

namespace laba2New.Drawing
{
    public class LineDrawer : FigureDrawer
    {
        public override void DrawFigure(Shape figure, List<Point> pointList, Graphics graphics)
        {
            Point[]list = figure.AddСoordinates(pointList);
            graphics.DrawPolygon(pen, list);
        }
    }
}