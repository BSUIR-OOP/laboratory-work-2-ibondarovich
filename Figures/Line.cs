using System.Collections.Generic;
using System.Drawing;

namespace laba2
{
    class Line: Point
    {
        private Point point1;
        private Point point2;
        public Line(List<System.Drawing.Point> pointsList,Graphics graphics):base(pointsList, graphics)
        {
            try
            {
                point1 = new Point(pointsList[0].X, pointsList[0].Y);
                point2 = new Point(pointsList[1].X,pointsList[1].Y);
            }
            catch
            {
                
            }
        }
        public override void DrawFigure()
        {
            graphics.DrawLine(pen, point1.X, point1.Y, point2.X, point2.Y);
        }
    }
}
