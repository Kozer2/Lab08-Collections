﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections.Classes
{
    public class Library : ILibrary
    {
        public int Count => throw new NotImplementedException();

        public void Add(string title, string firstName, string lastName, int numberOfPages)
        {
            throw new NotImplementedException();
        }

        public Book Borrow(string title)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<Book> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Return(Book book)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
