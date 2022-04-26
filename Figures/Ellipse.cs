using System;
using System.Collections.Generic;
using System.Drawing;

namespace laba2
{
    class Ellipse:Point
    {
        private int semi_axel1;
        private int semi_axel2;
        public Ellipse(List<System.Drawing.Point> pointsList,Graphics graphics):base(pointsList , graphics)
        {
            try
            {
                X = pointsList[0].X;
                Y = pointsList[0].Y;
                Semi_axel1 = Math.Abs(pointsList[1].X - pointsList[0].X);
                Semi_axel2 = Math.Abs(pointsList[2].Y - pointsList[0].Y);
            }
            catch 
            {

            }
        }
        public int Semi_axel1
        {
            get
            {
                return semi_axel1;
            }
            set
            {
                semi_axel1 = value;
            }
        }
        public int Semi_axel2
        {
            get
            {
                return semi_axel2;
            }
            set
            {
                semi_axel2 = value;
            }
        }
        public override void DrawFigure()
        {
            graphics.DrawEllipse(pen,X-semi_axel1,Y-semi_axel2,Semi_axel1*2,Semi_axel2*2);
        }
    }
}
