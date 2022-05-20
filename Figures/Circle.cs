using laba2New.Shapes;
using System.Drawing;
using laba2New.Drawing;
using System.Collections.Generic;
using System;

namespace laba2New.Figures
{
    public class Circle : Shape
    {
        private int radius;
        public override FigureDrawer figureDrawer { get; set; }

        public Circle()
        {
            figureDrawer = new CurveDrawer();
        }

        public override Point[] AddСoordinates (List<Point> pointsList)
        {
            if (Math.Abs(pointsList[0].X - pointsList[1].X) > Math.Abs(pointsList[0].Y - pointsList[1].Y))
                radius = Math.Abs(pointsList[0].X - pointsList[1].X);
            else
                radius = Math.Abs(pointsList[0].Y - pointsList[1].Y);
                
            pointsArray = new Point[] {pointsList[0], new Point(radius, radius)};

            return pointsArray;
        }
    }
}