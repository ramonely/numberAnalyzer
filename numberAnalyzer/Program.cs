using System;
using System.Linq;

namespace numberAnalyzer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool backToTop = true;

            while (backToTop)
            {
                Console.WriteLine("\nWelcome to the Number Analyzer! \n");
                Console.Write("What is your name? ");
                string name = Console.ReadLine();

                Console.WriteLine($"\n{name}, Enter a number between 1 and 100: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number < 1 || number > 100)
                {
                    Console.WriteLine($"\nThats was a invaild input. " +
                        $"\nYou can only enter a number bewtween 1 and 100 {name}.\nDo you want to start over: Yes or No? ");
                    string letsSee = Console.ReadLine().ToLower();
                    if (letsSee == "yes")
                        backToTop = true;
                    else if (letsSee == "no")
                    {
                        backToTop = false;
                        Console.WriteLine($"Thank you for stoping by {name}!");
                    }
                }
                else if (number >= 1 || number <= 100)
                {
                    int result = number % 2;
                    Console.WriteLine();

                    if (result == 1)
                    { Console.WriteLine($"{name}, This is your result \n{number}: is Odd."); }
                    else if (result == 0 & number >= 2 & number <= 25)
                    { Console.WriteLine($"{name}, This is your result \n{number}: is Even and less than 25."); }
                    else if (result == 0 & number >= 26 & number <= 60)
                    { Console.WriteLine($"{name}, This is your result \n{number}: is Even"); }
                    else if (result == 0 & number > 60)
                    { Console.WriteLine($"{name}, This is your result \n{number}: is Even"); }
                    else if (result == 1 & number > 60)
                    { Console.WriteLine($"{name}, This is your result \n{number}: is Odd"); }

                    Console.WriteLine($"\nDo you want to check another number {name}? Enter: Yes or No");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "no")
                    {
                        backToTop = false;
                        Console.WriteLine($"Thank you for stoping by {name}!");
                    }
                    else if (answer == "yes")
                        backToTop = true;
                }
            }
        }
    }
}