using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class FigureList
    {
        private List<Point> figureList = new List<Point>(); 

        public void AddList(Point figure)
        {
            figureList.Add(figure);
        }

        public void DrawFigures()
        {
            foreach (var figure in figureList)
            {
                figure.ShowFigure();
            }
        }
    }
}
