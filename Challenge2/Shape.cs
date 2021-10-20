using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2
{
    public abstract class Shape
    {

        private string _shapecolor;

        public string ShapeColor
        {
            get { return _shapecolor;  }
            set { _shapecolor = value; }
        }
        public Shape()
        { }
        public Shape(string ShapeColor)
        {
            _shapecolor = ShapeColor;
        }
        public abstract double GetArea();

        public virtual string AShape()
        {
            return "I am a shape";
        }

        public string Sides()
        {
            return "It is true that I have at least two sides";
        }

        public string Dimension()
        {
            return "The current shape classes are in the second dimension";
        }
       
    }
    
}
