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

            do {
                Console.Write("Guess the number: ");
                yourChoice = int.Parse(Console.ReadLine());

                if (yourChoice == number) {
                    Console.WriteLine($"Congrats! You did it. {yourChoice} is the correct number");
                    break;
                }
                else Console.WriteLine("Try Again!\n");

            } while (yourChoice != number);
        }
    }
}
