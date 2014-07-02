using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGarnett
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int num1;
            int num2;
            int smallest;
            
            Console.WriteLine("Enter a number: ");
            num1 = Console.ReadLine(num1);

            Console.WriteLine("Enter another number: ");
            num2 = Console.ReadLine(num2);

            Console.WriteLine("Smallest number is: " + smallest) = FindSmallestInteger(int num1, int num2);
        }

        public int FindSmallestInteger(int num1, int num2)
        {


            if (num1 < num2)
                return num1;
            else
                return num2;

         }
    }
}
