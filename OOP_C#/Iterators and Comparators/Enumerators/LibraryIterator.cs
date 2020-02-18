using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Enumerators
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private int currIndex;

        private Book[] books;
        public Book Current
        {
            get
            {
                return books[currIndex];
            }
        }
        object IEnumerator.Current => Current;
        public void Dispose()
        {
            books = null;
        }

        public bool MoveNext()
        {
            return ++currIndex < books.Length;
        }

        public void Reset()
        {
            currIndex = -1;
        }
        public LibraryIterator(List<Book> books)
        {
            this.books = books.ToArray();
            Reset();
        }
    }
}
