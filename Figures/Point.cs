using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    { 
        private double x;
        private double y;


        protected Point()
        {

        }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X
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

        public double Y
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

        public virtual void ShowFigure()
        {
            Console.WriteLine("Точка с координатами ({0};{1})",X,Y);
        }
    }
}
