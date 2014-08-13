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
            // Read the name and price for all three into the class named Book.
            Book book1 = new Book {Name = "Gone With The Wind", Price = 89.99M};
            Book book2 = new Book("The Wizard Of Oz", 45.00M);
            Book book3 = new Book();
            book3.Name = ("Rear Window");
            book3.Price = 24.50M;

            // Display the name and price for all three.
            Console.WriteLine(book1.Name + " " + book1.Price);
            Console.WriteLine(book2.Name + " " + book2.Price);
            Console.WriteLine(book3.Name + " " + book3.Price);
            Console.WriteLine();

//-----------------------------------------------------------------------------
//-----------------------------------------------------------------------------

            // Use the Compare method in the Book class to return a value.
            Book book4 = new Book();
            Book book5 = new Book();
            Console.WriteLine("Enter the first book price:");
            book4.Price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second book price:");
            book5.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine(book4.Compare(book5));
            Console.ReadLine();
        }
    }
}
