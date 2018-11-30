using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHaveNoIdeaWhatTheFucImTalkingAbout
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Insert a number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num == 0 || num == 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(num + " is not prime a number");
                Console.ResetColor();
               
                Console.ReadLine();
            }
            else
            {
                for (int a = 2; a <= num / 2; a++)
                {
                    if (num % a == 0)
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine(num + " is not a prime number");
                        Console.ResetColor();
                        Console.ReadLine();

                        return;
                    }

                }
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(num + " is a prime number");
                Console.ResetColor();
                Console.ReadLine();
            }
        }

    }
}