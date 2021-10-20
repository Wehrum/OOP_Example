using System;

namespace Challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region New Triangle Demo

            Triangle name = new Triangle();
            name.ShapeColor = "red";
            name.Base = 50;
            name.Height = 30;
            Console.WriteLine($"The area is {name.GetArea()} and the color of your shape is {name.ShapeColor}");

            #endregion

            #region Triangle Method Override Demo

            //Console.WriteLine(Triangle.RTGetSide());

            #endregion

            #region New Rectangle Demo

            Rectangle Rec = new Rectangle();
            Rec.ShapeColor = "blue";
            Rec.Side1 = 5;
            Rec.Side2 = 3;
            Console.WriteLine($"The area is {Rec.GetArea()} and the color of your shape is {Rec.ShapeColor}");

            #endregion

            #region Rectangle Construct Override Demo

            Rectangle Rec1 = new Rectangle(5, 3);
            Rec1.ShapeColor = "green";


            #endregion

        }
    }
}
