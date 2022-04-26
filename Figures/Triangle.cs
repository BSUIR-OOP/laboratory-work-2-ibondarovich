using System.Collections.Generic;
using System.Drawing;

namespace laba2
{
    class Triangle: Point
    {
        private Point point1;
        private Point point2;
        private Point point3;
        
        public Triangle(List<System.Drawing.Point> pointsList,Graphics graphics): base(pointsList, graphics)
        {
            try
            {
                point1 = new Point(pointsList[0].X, pointsList[0].Y);
                point2 = new Point(pointsList[1].X,pointsList[1].Y);
                point3 = new Point(pointsList[2].X,pointsList[2].Y); 
            }
            catch
            {

            } 
        }

        public override void DrawFigure()
        {
            graphics.DrawLine(pen, point1.X, point1.Y, point2.X, point2.Y);
            graphics.DrawLine(pen, point1.X, point1.Y, point3.X, point3.Y);
            graphics.DrawLine(pen, point2.X, point2.Y,point3.X, point3.Y);
        }
    }
}
