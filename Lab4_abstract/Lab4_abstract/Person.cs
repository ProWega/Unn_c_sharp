using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class Person
    {
        static Random random = new Random();
        public string name;
        protected int age;
        public static List<Person> All = new List<Person>();
        public Person(string name_, int age_=18)
        {
            name = name_;
            age = age_;
            All.Add(this);
        }
        virtual public void Print()
        {
            Console.WriteLine($"Персона {name}, возраст {age}");
        }
        public override string ToString()
        {
            return $"Person {name}, {age} y.o.";
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
        public virtual object Clone()
        {
            return new Person(this.name, this.age);
        }
        public static Person RandomPerson()
        {
            return All[random.Next(All.Count() - 1)];
        }
    }
}
