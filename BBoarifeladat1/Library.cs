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

        public Library(string name)
        {
            Name = name;
            List<Book> books = new List<Book>();
        }
        public void AddBooks()
    }
}
