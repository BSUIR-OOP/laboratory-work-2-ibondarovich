using laba2New.Shapes;
using laba2New.Drawing;
using System.Drawing;
using System.Collections.Generic;

namespace laba2New.Figures
{
    public class Triangle : Shape
    {

        public override FigureDrawer figureDrawer { get; set; }

        public Triangle()
        {
            figureDrawer = new LineDrawer();
        }
        public override Point[] AddСoordinates(List<Point> pointsList)
        {
            pointsArray = new Point[] {pointsList[0], pointsList[1], pointsList[2]};
            return pointsArray;
        }
    }
}