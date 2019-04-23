using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            //defining variables for number and the while loop
            int n;
            string response = "y";

            //while loop for continue y/n
            while (response == "y")
            {
                //prompt and input
                Console.WriteLine("Enter a number in between 1 and 100: ");
                n = int.Parse(Console.ReadLine());
                //proccessing
                //variable is even
                if (n % 2 == 0)
                {
                    Console.WriteLine("The number is Even!");
                    if (n >= 2 && n <= 25)
                    {
                        Console.WriteLine("The number is even and less than 25");
                    }
                    if (n > 60)
                    {
                        // print the number entered
                        Console.WriteLine(n);
                    }
                }
                else
                {
                    Console.WriteLine("The number is Odd!");
                    if (n > 60)
                    {
                        Console.WriteLine(n);
                    }
                }
                    Console.WriteLine("Continue? (y/n): ");
                // end of while loop
                    response = Console.ReadLine();
            }
                     // \n creates new line
                        Console.WriteLine("\nBye!");



        }
    }
}
