using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Collections.Classes
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public int Pages { get; set; }

        public Book(string title, string firstName, string lastName, int numberOfPages)
        {
            Title = title;
            Author = firstName + " " + lastName;
            Pages = numberOfPages;
        }
    }
}
