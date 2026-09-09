using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBoarifeladat1
{
    public class Book
    {
        private int _pageCount;
        public int count =0;
        public bool isAvalable = true;
        public int BookCount { get { return count; } }
        public string Title { get; set; }
        public string Author { get; set; }
        
        public int PageCount 
        {
            get { return _pageCount; }
            set
            {
                if (value < 0)
                { 
                    _pageCount = 0;
                }
                else 
                {
                    _pageCount = value; 
                }
            
            }
        }

        public Book(string title, string author, int pageCount)
        {
            Title = title;
            Author = author;
            PageCount = pageCount;
            count++;
        }
        public Book(string title, string author)
        {
            Title = title;
            Author = author;
            PageCount = 0;
        }

        public void Discribe() 
        {
            Console.WriteLine($"{Title}--{Author}--{PageCount}");
        }
        public bool IsLong() 
        {
            if(PageCount>300)
                return true;
            else
                return false;
        }
        public bool Borrow() 
        {
            if (isAvalable) 
            {
                isAvalable = false;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Return()
        {
            isAvalable = true;
        }
        




    }
}
