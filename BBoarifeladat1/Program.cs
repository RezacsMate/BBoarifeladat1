using System.Threading.Channels;

namespace BBoarifeladat1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Friend!");
            Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", 180);
            Book book2 = new Book("To Kill a Mockingbird", "Harper Lee", 281);
            Console.WriteLine(book1.Title);
            Console.WriteLine(book2.Title);
            Console.WriteLine("------------");
            book1.Discribe();
            book2.Discribe();
            Book book3 = new Book("War and Peace", "Leo Tolstoy");
            Console.WriteLine("------------------");
            List<Book> books = new List<Book>();
            
            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(new Book("The Catcher in the Rye", "J.D. Salinger", 214));
            books.Add(new Book("Pride and Prejudice", "Jane Austen", 432));
            Library library = new Library("My Library", books);
            
            Console.WriteLine("-------------");
            library.AvailableBooks();
            Console.WriteLine("-------------");

            book3.Borrow();
            library.AvailableBooks();
            Console.WriteLine("-------------");
            Librarian librarian = new Librarian(library, "katharin");

        }
    }
}
