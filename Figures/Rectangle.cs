using System.Drawing;
using System.Collections.Generic;
using System;

namespace laba2
{
    class Rectangle: Point
    {
        private int width;
        private int height;
        public Rectangle(List<System.Drawing.Point> pointsList,Graphics graphics):base(pointsList, graphics)
        {
            try
            {
                X = pointsList[0].X;
                Y = pointsList[0].Y;
                width = Math.Abs(pointsList[1].X-pointsList[0].X);
                height = Math.Abs(pointsList[2].Y-pointsList[0].Y);
            }
            catch
            {

            }  
        }
        public int Width
        {
            get 
            {
                return width;
            }
            set
            {
                width = value;
            }
        } 

        public int Height 
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public override void DrawFigure()
        {
            graphics.DrawRectangle(pen, X, Y, Width, Height);
        }
    }
}
