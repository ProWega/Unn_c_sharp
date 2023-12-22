using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public class BookGenre : Book
    {
        public string Genre;
        public BookGenre(string name, string author, float price, string genre) : base(name, author, price)
        {
            Genre = genre;
        }
        public void Print()
        {
            base.Print();
        }
    }
}
