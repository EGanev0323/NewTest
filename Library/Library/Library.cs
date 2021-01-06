using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            //return new LibraryIterator(this.books);
            for (int i = 0; i < books.Count; i++)
            {
                yield return this.books[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        //private class LibraryIterator : IEnumerator<Book>
        //{
        //    private int currentIndex;
        //    private readonly List<Book> books;
        //    public LibraryIterator(List<Book> books)
        //    {
        //        this.Reset();
        //        this.books = books;
        //    }
        //    public Book Current => this.books[currentIndex];

        //    object IEnumerator.Current => this.Current;

        //    public void Dispose()
        //    {

        //    }

        //    public bool MoveNext()
        //    {
        //        currentIndex++;
        //        return currentIndex < this.books.Count;
        //    }

        //    public void Reset()
        //    {
        //        this.currentIndex = -1;
        //    }

        //}
    }
}
