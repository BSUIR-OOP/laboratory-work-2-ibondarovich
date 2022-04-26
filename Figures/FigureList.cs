using System.Collections.Generic;
using System.Drawing;

namespace laba2
{
    class FigureList
    {
        private List<Point> figureList;
        public FigureList(List<System.Drawing.Point> pointsList, Graphics graphics)
        {
            figureList = new List<Point>()
            {
                new Point(pointsList, graphics),
                new Line(pointsList, graphics),
                new Circle(pointsList, graphics),
                new Ellipse(pointsList, graphics),
                new Rectangle(pointsList, graphics),
                new Triangle(pointsList, graphics)
            };
        }
        public void DrawFigure(int indexOfSelectedItem)
        {
            foreach(var figure in figureList)
            {
                if(figureList.IndexOf(figure) == indexOfSelectedItem)
                {
                    figure.DrawFigure();
                }
            }
        }
    }
}
