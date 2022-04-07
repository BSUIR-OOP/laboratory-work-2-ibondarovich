using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureList figureList = new();
            figureList.AddList(new Point(20, 30));
            figureList.AddList(new Line(20, 30, 50, 10));
            figureList.AddList(new Ellipse(0,0,5,3));
            figureList.AddList(new Circle(6,10,20));
            figureList.AddList(new Rectangle(3,4,20,100));
            figureList.AddList(new Triangle(10,20,30,40,50,60));

    

            figureList.DrawFigures();
            
        }
    }
   
}
