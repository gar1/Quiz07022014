using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGarnett2
{
    //----------------------------------------------------------------------------------------|
    // I went home and worked on quiz problem #2.  I could NOT figure this one out on my own. | 
    //----------------------------------------------------------------------------------------|
    class Book
    {
        private string name;
        private decimal price;

        public Book(string name, decimal price);

        public string Name
        {
            get {return name;}
            set {name = value;}
        }

        public decimal Price
        {
            get {return price;}
            set {price = value;}
        }

        public int Compare()
        {

            return 1;

        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            Book book1 = new Book(name, price){"Gone With The Wind", 89.99};
            Book book2 = new Book("The Wizard Of Oz", 45.00);

            Console.WriteLine(book1.name + " " + book1.price);
            Console.WriteLine(book2.name + " " + book2.price);



        }
    }
}
