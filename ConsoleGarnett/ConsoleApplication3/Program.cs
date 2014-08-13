using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string remainder;
            int number = 0;

            for (int n = 1; n <= 100; n++)
            {
                if ((n % 3 == 0) & (n % 5 == 0))
                {
                    remainder = "FizzBuzz";
                    Console.WriteLine(remainder);
                }
                else if (n % 3 == 0)
                {
                    remainder = "Fizz";
                    Console.WriteLine(remainder);
                }
                else if (n % 5 == 0)
                {
                    remainder = "Buzz";
                    Console.WriteLine(remainder);
                }
                else
                {
                    number = n;
                    Console.WriteLine(number);
                }
            }

            Console.ReadLine();
        }
    }
}
