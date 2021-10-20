using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2
{
    public class Rectangle : Shape
    {
        private double _side1;
        private double _side2;

        public double Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }

        public double Side2
        {
            get { return _side2;  }
            set { _side2 = value; }
        }

        public Rectangle(double Side1, double Side2)
        {
            _side1 = Side1;
            _side2 = Side2;
        }

        public Rectangle(double Side1, double Side2, string ShapeColor)
        {
            _side1 = Side1;
            _side2 = Side2;
            this.ShapeColor = ShapeColor;
        }

        public Rectangle()
        { }

        public override double GetArea()
        {
            double result = Side1 * Side2;
            return result;
        }

        public override string AShape()
        {
            return "This is a rectangle";
        }
    }
}
