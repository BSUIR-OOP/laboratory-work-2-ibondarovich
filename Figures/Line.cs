using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Line: Point
    {
        private Point point1;
        private Point point2;
        public Line(double x1, double y1, double x2, double y2)
        {
            point1 = new Point(x1,y1);
            point2 = new Point(x2,y2);
        }
        
        public override void ShowFigure()
        {
            Console.WriteLine("Отрезок с координатами ({0},{1}) и ({2},{3})",point1.X,point1.Y,point2.X,point2.Y);
        }
    }
}
