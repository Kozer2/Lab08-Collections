using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections.Classes
{
    public class Library : ILibrary
    {
        private Dictionary<string, Book> dictionary = new Dictionary<string, Book>();
        public int Count { get; private set; }

       

        public void Add(string title, string firstName, string lastName, int Pages)
        {
            Book newBook = new Book(title, firstName, lastName, Pages);
            dictionary.Add(title, newBook);
            Count++;
        }

        public Book Borrow(string title)
        {
            Book book;
            bool containsBook = dictionary.TryGetValue(title, out book);
            if (containsBook)
            {
                dictionary.Remove(title);
                Count--;
            }
            return book;
        }

        public IEnumerator<Book> GetEnumerator()
        {
            foreach (Book book in dictionary.Values)
            {
                yield return book;
            };
        }

        public void Return(Book book)
        {
            dictionary.Add(book.Title, book);
            Count++;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
