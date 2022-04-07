using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ellipse:Point
    {
        private double semi_axel1;
        private double semi_axel2;

        public Ellipse(double x, double y, double semi_axel1, double semi_axel2) :base(x,y)
        {
            Semi_axel1 = semi_axel1;
            Semi_axel2 = semi_axel2;
        }

        public double Semi_axel1
        {
            get{
                return semi_axel1;
            }

            set{
                semi_axel1 = value;
            }
        }
        public double Semi_axel2
        {
            get{
                return semi_axel2;
            }

            set{
                semi_axel2 = value;
            }
        }

        public override void ShowFigure()
        {
            Console.WriteLine("Эллипс с центром в точке ({0};{1} и полуосями {2} и {3})",X,Y,Semi_axel1,Semi_axel2);
        }
    }
}
