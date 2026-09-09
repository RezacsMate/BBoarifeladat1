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

            Console.WriteLine();
        }
    }
}
