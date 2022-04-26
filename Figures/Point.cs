using System.Collections.Generic;
using System.Drawing;

namespace laba2
{
    class Point
    { 
        protected int x;
        protected int y;
        protected Graphics graphics;
        protected Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0), 3);

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Point(List<System.Drawing.Point> pointsList,Graphics graphics)
        {
            try
            {
                X = pointsList[0].X;
                Y = pointsList[0].Y;
                this.graphics = graphics;
            }
            catch
            {

            }
        }
        public int X
        {
            get
            {
                return x;
            }
            set
            {
                this.x = value;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                this.y = value;
            }
        }
        public virtual void DrawFigure()
        {
            graphics.DrawRectangle(pen,X,Y, 1, 1);
        }
    }
}
