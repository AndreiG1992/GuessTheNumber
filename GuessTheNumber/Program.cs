using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int yourChoice, number;
            
            Random random = new Random();
            number = random.Next(1,100);
            Console.Write("\t\t\t\t*********************************************************************\n");
            Console.Write("\t\t\t\t*\t\t\t\t\t\t\t\t\t*\n");
            Console.Write("\t\t\t\t*\t\t\t\tGUESS THE NUMBER\t\t\t*\n");
            Console.Write("\t\t\t\t*\t\t\t\t\t\t\t\t\t*\n");
            Console.Write("\t\t\t\t*********************************************************************\n");
            Console.WriteLine("What's Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, let's play \"Guess the number\"");
            do {
                Console.Write("Choose a number from 1 to 100: ");
                yourChoice = int.Parse(Console.ReadLine());
                if(yourChoice < 1 || yourChoice >100)
                {
                    Console.WriteLine("Wrong number! Your choice must be from 1 to 100");
                    continue;
                }

                if (yourChoice == number) {
                    Console.WriteLine($"Congrats! You did it. {yourChoice} is the correct number");
                    break;
                }
                else Console.WriteLine("Try Again!\n");

            } while (yourChoice != number);
        }
    }
}
