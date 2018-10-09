using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab4
{
    class Program
    {
        static void Main()
        {
            /* 
             * prompts an integer from user
             * provides table of squares and cubes from 1 to value entered
             * prompts to continue
             */

            string cont = "y";
            Console.WriteLine("Make a table of squares and cubes!");

            while (cont == "y")
            {
                Console.Write("Enter a positive integer: ");
                int cubeLimit;
                while (!int.TryParse(Console.ReadLine(), out cubeLimit) || cubeLimit < 1)
                {
                    Console.Write("That's not a positive integer. Please try again: ");
                }
                int count = 1;
                Console.WriteLine("\n");
                Console.WriteLine(string.Format("{0,6} {1,12} {2,10}","Number:","Squared:","Cubed:"));
                Console.WriteLine(string.Format("{0,6} {1,12} {2,10}", "======","======","====="));
                do
                {
                    Console.WriteLine(string.Format("{0,6} {1,12} {2,10}", count, (count * count), (count * count * count)));
                    count += 1;
                } while (count <= cubeLimit);

                Console.WriteLine("\n");
                Console.Write("Would you like to make another table? (y/n) ");
                cont = Console.ReadLine().ToLower();
                Console.WriteLine("\n");
            }
            Console.WriteLine("Goodbye!");
            Console.ReadKey();
        }
    }
}
