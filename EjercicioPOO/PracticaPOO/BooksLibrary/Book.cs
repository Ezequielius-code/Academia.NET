using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Book
    {
        private string isbn;
        private string title;
        private string author;
        private int numberOfPages;

        private Book()
        {
            this.isbn = Data.GenerateISBN();
            this.title = Data.GenerateTitle();
            this.author = Data.GenerateAuthor();
            this.numberOfPages = Data.GenerateNumberOfPages();
        }

        private Book (string ISBN, string title, string author, int numberOfPages)
        {
            this.isbn = ISBN;
            this.title = title;
            this.author = author;
            this.numberOfPages = numberOfPages;
        }

        public static void AutoBookLoad()
        {
            Book book = new Book();
            DisplayLoadedBook(book);
        }

        public static void ManualBookLoad(string ISBN, string title, string author, int numberOfPages)
        {
            Book book = new Book(ISBN, title, author, numberOfPages);
            DisplayLoadedBook(book);
        }

        private static void DisplayLoadedBook(Book book)
        {
            Console.Write($"BOOK LOADED:\n-Title: {book.title}\n-Author: {book.author}\n-Number of pages: {book.numberOfPages}\n-ISBN: {book.isbn}\n\n");
        }
    }
}
