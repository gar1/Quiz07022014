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
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            num2 = int.Parse(Console.ReadLine());
 
            smallest = FindSmallestInteger(num1, num2);

            Console.WriteLine("Smallest number is: " + smallest);

            Console.ReadLine();
        }

        public static int FindSmallestInteger(int num1, int num2)
        {


            if (num1 < num2)
                return num1;
            else
                return num2;

         }
    }
}
