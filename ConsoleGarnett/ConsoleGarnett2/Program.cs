using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGarnett2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book;

            book = new Book("Redbook", "Greenbook", 24.99, 9.99);
            Console.WriteLine(book.Compare());

        }
    }
}
