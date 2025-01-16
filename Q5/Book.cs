using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Q5
{
    public class Book
    {
         public string Title { get; set; }
        public string Author { get; set; }
        public int ISBN { get; set; }
        public Book(string _title,string _author,int _isbn) { 
            Title = _title; 
            Author = _author;
            ISBN = _isbn;
        }
        //public override string ToString()
        //{
        //    return $"Title={Title}, Author={Author}, ISBN={ISBN}";
        //}
        public virtual void dispalyBook()
        {
            Console.WriteLine($"Title={Title}");
            Console.WriteLine($"Author={Author}");
            Console.WriteLine($"ISBN={ISBN}");
        }
    }
}
