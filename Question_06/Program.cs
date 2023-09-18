using Que7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Que7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bookshelf bookshelf = new Bookshelf(10);
            bookshelf.AddBook("Life Divine", "Sri Aurbindo Ghosh");
            bookshelf.AddBook("Lost Child", "Mulk Raj Anand");
            bookshelf.AddBook("My Days", "R.K. Narayan");
            bookshelf.AddBook("My India", "S. Nihal Singh");
            bookshelf.AddBook("Arthashastra", "Kautilya");

            Console.WriteLine("Author of 'Life Divine': " + bookshelf["Life Divine"]);
            Console.WriteLine("Author of 'Lost Child': " + bookshelf["Lost Child"]);
            Console.WriteLine("Author of 'My Days': " + bookshelf["My Days"]);
            Console.WriteLine("Author of 'My India': " + bookshelf["My India"]);
            Console.WriteLine("Author of 'Arthashastra': " + bookshelf["Arthashastra"]);
        }
    }
    public class Bookshelf
    {
        private Book[] books;
        private int bookCount;

        public Bookshelf(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than 0");
            }

            books = new Book[capacity];
            bookCount = 0;
        }

        public void AddBook(string title, string author)
        {
            if (bookCount < books.Length)
            {
                books[bookCount] = new Book(title, author);
                bookCount++;
            }
            else
            {
                Console.WriteLine("Bookshelf is full. Cannot add more books.");
            }
        }

        public string this[string title]
        {
            get
            {
                for (int i = 0; i < bookCount; i++)
                {
                    if (books[i].Title == title)
                    {
                        return books[i].Author;
                    }
                }
                throw new ArgumentException("Book with title '{title}' not found.");
            }
        }
    }

    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }
}