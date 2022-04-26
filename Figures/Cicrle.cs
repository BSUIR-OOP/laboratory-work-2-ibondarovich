using System;
using System.Collections.Generic;
using System.Drawing;

namespace laba2
{
    class Circle: Ellipse
    {
        private int radius;
        public Circle(List<System.Drawing.Point> pointsList,Graphics graphics):base(pointsList, graphics)
        {
            try
            {
                if (Math.Abs(pointsList[0].X - pointsList[1].X) > Math.Abs(pointsList[0].Y - pointsList[1].Y))
                    Radius = Math.Abs(pointsList[0].X - pointsList[1].X);
                else
                    Radius = Math.Abs(pointsList[0].Y - pointsList[1].Y);
            }
            catch 
            {

            }
        }
        public int Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }
        public override void DrawFigure()
        {
            graphics.DrawEllipse(pen,X-radius,Y-radius,radius*2,radius*2);
        }
    }
}
