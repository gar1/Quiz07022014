using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGarnett2
{
    class Book
    {
        private string name;
        private decimal price;

        public Book(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Book()
        {
            name = "";
            price = 0M;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Price { get; set; }

        public int Compare(Book OtherBook)
        {
            if (this.Price > OtherBook.Price)
            {
                return 1;
            }
            else if (this.Price < OtherBook.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
