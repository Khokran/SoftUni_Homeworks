using System;
using System.Collections.Generic;
using System.Linq;

namespace Enumerators
{
    public class Program 
    { 
        static void Main()
        {
            var books = new List<Book>()
            {
                new Book ("Harry Potter", 2000, "J.K. Rolling"),
                new Book ("Тhe sign of the four", 1876, "A.K. Doil"),
                new Book ("Dancing with Dragons", 2012, "Martin"),
                new Book ("I, robot", 1978, "A. Azimov"),
                new Book ("I, robot", 1985, "A. Azimov"),
            };
            // books = books.OrderBy(b => b.Title).ThenBy(b => b.Year).ToList();

            var library = new Library(books);
            foreach (var book in library)
            {
                Console.WriteLine(book);
            }
        }
    }
}
