using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GregLGraemeMLab6
{
    public abstract class Book
    {
        public int Code { get; set; }
        public string title;
        public string Title
        {
            get { return title; }
            set { title = value?.ToUpper(); }
        }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}, {Price:C}";
        }
        // Overloaded -- operator to add 1 from stock
        public static Book operator ++(Book book)
        {
            book.Stock++;
            return book;
        }

        // Overloaded -- operator to subtract 1 from stock
        public static Book operator --(Book book)
        {
            if (book.Stock > 0)
            {
                book.Stock--;
            }
            return book;
        }
    }
}

