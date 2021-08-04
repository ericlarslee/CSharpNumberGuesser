using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.WriteLine("Guess a number in between 0 and 100");
                string userInput = Console.ReadLine();

                int userNumber = int.Parse(userInput);

                if (userNumber > winNum)
                {
                    Console.WriteLine("Your guess is too high, pick a lower number");
                }
                else if (userNumber < winNum)
                {
                    Console.WriteLine("Your guess is too low, pick a higher number");
                }
                else if (userNumber == winNum)
                {
                    Console.WriteLine("You win. Do you want a cookie");
                    win = true;
                }

            } while (win == false);
            Console.WriteLine("The game is over. You should leave the console now");
        }
    }
}
