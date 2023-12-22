using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class Triangle : Figure
    {
        private float a, b, c;
        public float A { get { return a; } set { if (value < 0) value = -value; a = value; } }
        public float B { get { return b; } set { if (value < 0) value = -value; b = value; } }
        public float C { get { return c; } set { if (value < 0) value = -value; c = value; } }

        public Triangle(string name, float a, float b, float c) : base(name)
        {
            SetABC(a,b,c);
        }
        public void SetABC(float a, float b, float c)
        {
            a= Math.Abs(a);
            b= Math.Abs(b);
            c= Math.Abs(c);
            List<float> abc = new List<float> { a, b, c };
            abc.Sort();
            if (c >= a + b)
            {
                Console.WriteLine("Такой треугольник создать невозможно, ставим знаечния 3, 4, 5");
                a = 3; b = 4; c = 5;
            }
            this.A = a; this.B = b; this.C = c;
        }
        public float[] GetABC()
        {
            float[] res = { a, b, c };
            return res;
        }
        public override double Area2 { get => Area(); }

        public override double Area()
        {
            float p = (a + b + c) / 2;
            return Math.Sqrt(p * (p-a)*(p-b)*(p-c));
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Стороны: {a}, {b}, {c}");
        }
    }
}
