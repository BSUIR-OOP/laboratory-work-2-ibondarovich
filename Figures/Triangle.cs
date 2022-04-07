using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Triangle: Point
    {
        private Point point1;
        private Point point2;
        private Point point3;
        
        public Triangle(double x0, double y0, double x1, double y1, double x2, double y2)
        {
            point1 = new Point(x0,y0);
            point2 = new Point(x1,y1);
            point3 = new Point(x2,y2);
        }

        public override void ShowFigure()
        {
            Console.WriteLine("Треугольник с веришинами в точках ({0};{1}), ({2};{3}) и ({4};{5})",point1.X, point1.Y, point2.X, point2.Y, point3.X, point3.Y);
        }
    }
}
