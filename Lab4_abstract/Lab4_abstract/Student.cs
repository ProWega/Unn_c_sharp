using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class Student : Person
    {
        static Random random = new Random();
        public static List<Student> All = new List<Student>(); 
        public Student(string _name, int age_) : base(_name, age_)
        {
            All.Add(this);
        }
        virtual public void Print()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            return $"Student {name}, {age} years old";
        }
        public override bool Equals(object? obj)
        {
            if (obj.ToString() == this.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();

        }
        public override object Clone()
        {
            return new Student(name, age);
        }
        public static Person RandomStudent()
        {
            return All[random.Next(All.Count() - 1)];
        }
    }
}
