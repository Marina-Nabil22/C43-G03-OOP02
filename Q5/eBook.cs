using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP02.Q5
{
    public class eBook:Book
    {
        public int FileSize { get; set; }
        public eBook(int _filesize, string _title, string _author, int _isbn) :base( _title,  _author,  _isbn)
        {
            FileSize = _filesize;
        }
        public override void dispalyBook()
        {
            base.dispalyBook();
            Console.WriteLine($"FileSize={FileSize}\n");

        }
    }
}
