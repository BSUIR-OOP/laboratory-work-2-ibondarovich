using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Circle: Ellipse
    {

        private double radius;
        public Circle(double x, double y, double radius):base(x,y,radius,radius)
        {
            this.radius = radius;
        }

        public double Radius
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

        public override void ShowFigure()
        {
            Console.WriteLine("Окружность с центром в точке ({0};{1}) и радиусом {2}",X,Y,Radius);
        }
    }
}
