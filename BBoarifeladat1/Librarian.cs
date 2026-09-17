using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBoarifeladat1
{
    public class Librarian
    {
        private Library library;
        public string name { get; set; }
        public Librarian(Library library, string name )
        {
            this.library = library;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{name}--{library.Name}";
        }
        public string AddBooks(string title, string author, int pagecount) 
        {
            Book book = new Book(title, author, pagecount) ;
            library.AddBooks(book);
            return $"done, added book";
        }
    }
}
