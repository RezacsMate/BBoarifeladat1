using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BBoarifeladat1
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        public string Name { get; set; }

        public Library(string name, List<Book> books)
        {
            Name = name;
            this.books = books;
        }
        public void AddBooks(Book book)
        {
            books.Add(book);
        }
        public void PrintAll()
        {
            foreach (Book book in books)
            {
                book.Discribe();
            }
        }
        public Book FindByTitle(string title)
        {
            foreach (var book in books)
            {
                if (book.Title == title)
                {
                    return book;
                }
                else
                    return null;
            }
            return null;
        }
        public List<Book> FindByAuthor(string autor)
        {
            List<Book> authorBooks = new List<Book>();
            foreach (var x in books)
            {

                if (x.Author == autor)
                {
                    authorBooks.Add(x);
                }

            }
            return authorBooks;
        }
        public int TotalPages()
        {
            int db = 0;
            foreach (var x in books)
            {
                db += x.PageCount;
            }
            return db;
        }
        public double AveragePages()
        {
            int db = 0;
            foreach (var x in books)
            {
                db += x.PageCount;
            }
            return (double)db / books.Count;
        }
        public void AvailableBooks()
        {
            List<Book> availableBooks = new List<Book>();
            foreach (var x in books)
            {
                if (x.isAvalable == true)
                {
                    availableBooks.Add(x);
                    
                }
            }
            foreach (var x in availableBooks) 
            {
                x.Discribe();
            }


        }
    }
}
