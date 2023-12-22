using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public abstract class Figure
    {
        private string name;
        public abstract double Area2 { get; }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Figure(string name)
        {
            this.name = name;
        }
        public abstract double Area();
        public virtual void Print()
        {
            Console.WriteLine($"Figure {name}");
        }

    }
}
