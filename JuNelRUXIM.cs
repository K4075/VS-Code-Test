using System;
using System.Collections.Generic;
using System.Threading;

partial class Program
{
    static void Main()
    {
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Clear();
        Console.Title = "TestFinder v2.75.3 - By: K4075";

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome to TestFinder v2.75.3!");
            Console.WriteLine("1. Run Original Program");
            Console.WriteLine("2. Play Number Guessing Game");
            Console.WriteLine("3. Exit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine() ?? string.Empty;

            switch (choice)
            {
                case "1":
                    RunOriginalProgram();
                    break;
                case "2":
                    PlayNumberGuessingGame();
                    break;
                case "3":
                    ShowGoodbyeScreen();
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(1000);
                    break;
            }
        }
    }

    static void RunOriginalProgram()
    {
        Console.Clear();
        Console.WriteLine("Hi!");
        Console.WriteLine("Welcome to my program!");
        Console.WriteLine("This program is fun, it is finding hidden messages and codes in this text.");
        Console.WriteLine("Numero Uno = El primero palabra. Tambien para otras.");
        Console.WriteLine("OK that was nothing, but in later updates I will add more fun stuff.");
        Console.WriteLine("...OK Last Line!");
        Console.WriteLine($"The time is: {DateTime.Now:hh:mm tt}");
        Console.WriteLine($"The date is: {DateTime.Now:MM/dd/yyyy}");
        Console.WriteLine($"The day of the week is: {DateTime.Now:dddd}");
        Console.WriteLine($"The year is: {DateTime.Now:yyyy}");
        Console.WriteLine($"The month is: {DateTime.Now:MMMM}");
        Console.WriteLine($"The day of the month is: {DateTime.Now:dd}");
        Console.WriteLine($"The time zone is: {TimeZoneInfo.Local.StandardName}");
        Console.WriteLine(@"
████████╗███████╗███████╗████████╗███████╗██╗███╗   ██╗██████╗ ███████╗
╚══██╔══╝██╔════╝██╔════╝╚══██╔══╝██╔════╝██║████╗  ██║██╔══██╗██╔════╝
   ██║   █████╗  █████╗     ██║   █████╗  ██║██╔██╗ ██║██║  ██║█████╗  
   ██║   ██╔══╝  ██╔══╝     ██║   ██╔══╝  ██║██║╚██╗██║██║  ██║██╔══╝  
   ██║   ███████╗██║        ██║   ███████╗██║██║ ╚████║██████╔╝███████╗
   ╚═╝   ╚══════╝╚═╝        ╚═╝   ╚══════╝╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝");
        Console.WriteLine("\n\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    static void PlayNumberGuessingGame()
    {
        var random = new Random();
        int numberToGuess = random.Next(1, 101); // Random number between 1 and 100
        int attempts = 0;
        bool guessedCorrectly = false;

        Console.Clear();
        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("I have picked a number between 1 and 100. Can you guess it?");
        Console.WriteLine("Type your guess and press Enter:");

        while (!guessedCorrectly)
        {
            Console.Write("\nYour guess: ");
            string input = Console.ReadLine() ?? string.Empty;
            attempts++;

            if (int.TryParse(input, out int guess))
            {
                if (guess < numberToGuess)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > numberToGuess)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts.");
                    guessedCorrectly = true;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        Console.WriteLine("\nPress any key to return to the menu...");
        Console.ReadKey();
    }

    static void ShowGoodbyeScreen()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine(@"
 ██████╗  ██████╗  ██████╗ ██████╗  █████╗ ██╗   ██╗███████╗
██╔════╝ ██╔═══██╗██╔════╝ ██╔══██╗██╔══██╗██║   ██║██╔════╝
██║  ███╗██║   ██║██║  ███╗██████╔╝███████║██║   ██║█████╗  
██║   ██║██║   ██║██║   ██║██╔═══╝ ██╔══██║╚██╗ ██╔╝██╔══╝  
╚██████╔╝╚██████╔╝╚██████╔╝██║     ██║  ██║ ╚████╔╝ ███████╗
 ╚═════╝  ╚═════╝  ╚═════╝ ╚═╝     ╚═╝  ╚═╝  ╚═══╝  ╚══════╝
");
        Console.WriteLine("\nThank you for using TestFinder v2.75.3!");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
