using laba2New.Shapes;
using laba2New.Drawing;
using System.Drawing;
using System.Collections.Generic;

namespace laba2New.Figures
{

    public class Rectangle : Shape
    {
        public override FigureDrawer figureDrawer { get; set; }

        public Rectangle()
        {
            figureDrawer = new LineDrawer();
        }
        public override Point[] AddСoordinates (List<Point> pointsList)
        {
            Point point0 = pointsList[0];
            Point point1 = new Point(pointsList[1].X, pointsList[0].Y);
            Point point2 = new Point(pointsList[1].X, pointsList[2].Y);
            Point point3 = new Point(pointsList[0].X, pointsList[2].Y);


            pointsArray = new Point[] {point0, point1, point2, point3};

            return pointsArray;
        }
    }
}