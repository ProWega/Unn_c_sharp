using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class Book
    {
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
             }
        public string Author { get; set; }
        public float Price { get; set; }

        public Book(string name, string author, float price)
        {
            Name = name;
            Author = author;
            Price = price;
        }
        public void Print()
        {
            Console.WriteLine($"Книга: {Name}, автор {Author}, цена: {Price}");
        }
    }
}
