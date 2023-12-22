using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public enum ColorValues
    {
        black, white, blue, red
    }
    public class TriangleColor : Triangle
    {
        ColorValues color;

        public TriangleColor(string name, float a, float b, float c, ColorValues color_) : base(name, a, b, c)
        {
            color = color_;
        }
        public ColorValues Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Area2()
        {
            return base.Area2;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine(color);
        }

    }
}
