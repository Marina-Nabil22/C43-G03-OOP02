using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Q5
{
    public class PrintedBook:Book
    {
        public int PageCount { get; set;}
         public PrintedBook(int pageCount, string _title, string _author, int _isbn):base( _title,  _author,  _isbn)
        {
            PageCount = pageCount;
        }

        public override void dispalyBook()
        {
            base.dispalyBook();
            Console.WriteLine($"PageCount={PageCount}\n");

        }
    }
}
