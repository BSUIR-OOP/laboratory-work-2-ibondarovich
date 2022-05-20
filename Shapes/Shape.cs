using System.Drawing;
using System.Collections.Generic;

namespace laba2New.Shapes
{
    public abstract class Shape
    {        
        protected Point [] pointsArray;
        
        public abstract FigureDrawer figureDrawer {get; set;}

        public abstract Point[] AddСoordinates (List<Point> pointsList);
    }
}