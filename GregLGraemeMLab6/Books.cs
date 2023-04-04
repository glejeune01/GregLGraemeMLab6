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
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        public string Edition { get; set; }
        public int Stock { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author}, {Price:C}";
        }
    }
}
