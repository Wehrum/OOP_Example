using System;
using System.Collections.Generic;
using System.Text;

namespace Challenge2
{
     class Triangle : Shape
    {
        private double _h;
        private double _ba;
        public double Base
        {
            get { return _ba; }
            set
            {
                if (value >= 0.00001)
                {
                    _ba = value;
                }
                else
                {
                    Console.WriteLine("Triangle height can't be 0 or less than 0, yours was {0}..", value);
                    ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);
                    if (keyInfo1.Key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }
            }
        }
        public double Height
        {
            get { return _h; }
            set
            {
                if (value >= 0.000001)
                {
                    _h = value;
                }
                else
                {
                    Console.WriteLine("Triangle height can't be 0 or less than 0, yours was {0}..", value);
                    ConsoleKeyInfo keyInfo1 = Console.ReadKey(true);
                    if (keyInfo1.Key == ConsoleKey.Enter)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Environment.Exit(0);
                    }
                }    
            }
        }

        public Triangle()
        { }

        //RT stands for Right Triangle as this formula only works for right triangles :)
        public static double RTGetSide(double LegA, double LegB, int round)
        {
            if (LegA <= 0 || LegB <=0 || round > 15)
            {

                return -1;

            }
            else
            {
                double result = (LegA * LegA) + (LegB * LegB);

                result = Math.Sqrt(result);
                return Math.Round(result, round);
            }

        }
        public static double RTGetSide(string X, double LegB, double Hyp, int round)
        {
            {
                if(Hyp < LegB || round > 15 || Hyp <= 0 || LegB <= 0)
                {
                    
                    return -1;
                    
                }
                else
                {
                    double result = (Hyp * Hyp) - (LegB * LegB);
                    result = Math.Sqrt(result);
                    return Math.Round(result, round);
                }

            }
        }

        public static double RTGetSide(double LegA, string X, double Hyp, int round)
        {
            if (Hyp < LegA || round > 15 || Hyp <= 0 || LegA <= 0)
            {

                return -1;

            }
            else
            {
                double result = (Hyp * Hyp) - (LegA * LegA);
                result = Math.Sqrt(result);
                return Math.Round(result, round);
            }
        }

        public override double GetArea()
        {
                double result = (Height * Base) / 2;
                Math.Sqrt(result);
                return result;
           
        }

        public override string AShape()
        {
            return "This is a triangle";
        }

        public new string Dimension()
        {
            return "All shapes are now in 3D because I said so";
        }

    }
}
