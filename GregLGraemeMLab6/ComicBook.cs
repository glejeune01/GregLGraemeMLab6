using GregLGraemeMLab6;
using System;

public class ComicBook : Book, ICloneable
{
    public string Edition { get; set; }

    public object Clone()
    {
        return new ComicBook
        {
            Code = this.Code + 10000,
            Title = this.Title,
            Author = this.Author,
            Genre = this.Genre,
            Price = this.Price,
            Stock = this.Stock,
            Edition = this.Edition + " (Part 2)"
        };
    }
}
