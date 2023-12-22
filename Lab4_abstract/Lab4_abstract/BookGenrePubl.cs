using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_abstract
{
    public sealed class BookGenrePubl : BookGenre
    {
        string Publisher;
        public BookGenrePubl(string name, string author, float price, string genre, string publisher) : base(name, author, price, genre)
        {
            Publisher = publisher; 
        }
    }
}
