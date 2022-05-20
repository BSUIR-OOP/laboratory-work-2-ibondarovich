using System.Drawing;
using System.Collections.Generic;
using System;

namespace laba2New.Figures
{
    public class Ellipse : Circle
    {
        private int semi_axel1;
        private int semi_axel2;
        public override Point[] AddСoordinates (List<Point> pointsList)
        {

            semi_axel1 = Math.Abs(pointsList[1].X - pointsList[0].X);
            semi_axel2 = Math.Abs(pointsList[2].Y - pointsList[0].Y);

            pointsArray = new Point[] {pointsList[0], new Point(semi_axel1, semi_axel2)};

            return pointsArray;
        }
    }
}