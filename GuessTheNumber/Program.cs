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
            

            Console.Write("\t\t\t\t*********************************************************************\n");
            Console.Write("\t\t\t\t*\t\t\t\t\t\t\t\t\t*\n");
            Console.Write("\t\t\t\t*\t\t\t\tGUESS THE NUMBER\t\t\t*\n");
            Console.Write("\t\t\t\t*\t\t\t\t\t\t\t\t\t*\n");
            Console.Write("\t\t\t\t*********************************************************************\n");

            Console.WriteLine("What's Your Name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, let's play \"Guess the number\"");
            
            restart:
            int yourChoice, number, score = 1;
            Random random = new Random();
            number = random.Next(1, 100);
            do
            {
                
                Console.Write("Choose a number from 1 to 100: ");
                yourChoice = int.Parse(Console.ReadLine());
                if (yourChoice < 1 || yourChoice > 100)
                {
                    Console.WriteLine("Wrong number! Your choice must be from 1 to 100");
                    continue;
                }
                else
                {
                    if (yourChoice == number)
                    {
                        Console.WriteLine($"Right answer! {number} is the correct number");
                        Console.WriteLine($"You've succeeded in {score} attempts");
                        break;
                    }
                    else if (yourChoice < number)
                    {
                        Console.WriteLine("Too low! Try Again!");
                        ++score;
                    }
                    else
                    {
                        Console.WriteLine("Too high! Try Again");
                        ++score;
                    }

                }
            } while (yourChoice != number);
            Console.WriteLine("\n\nGame Over!\nWant another try?[y/n]");
            char optionToContinue = Convert.ToChar(Console.ReadLine());
            if (optionToContinue == 'y') goto restart;
            if (optionToContinue == 'n') Console.WriteLine("Goodbye");


        }

    }
}
