using System;

namespace YahtzeeTrailCoding
{
    class Program
    {
        private static readonly string _userIntErrTxt = "Invalid value entered, please an integer.";
        static void Main(string[] args)
        {
            Console.WriteLine($"Welcome to Trail Coding Yahtzee! { Environment.NewLine }");
            while (true)
                PlayGame();

        }

        private static void PlayGame()
        {

            Console.WriteLine("Please enter the number of dice you want to roll then hit enter");

            EnterDice:
            int numberOfDice = 0;
            try
            {

                numberOfDice = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{_userIntErrTxt}");
                goto EnterDice;
            }

            Console.WriteLine($"{ Environment.NewLine }Please enter the number of sides for each die then hit enter");

            EnterSides:
            int numberOfSides = 0;
            try
            {

                numberOfSides = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine($"{_userIntErrTxt}");
                goto EnterSides;
            }

            Console.WriteLine();

            for (int i = 1; i < 1001; i++)
            {
                var round = YahtzeeService.PlayRound(numberOfDice, numberOfSides);
                Console.WriteLine($"Round {i}: {round}");
            }

            Console.WriteLine();
        }
    }
}
