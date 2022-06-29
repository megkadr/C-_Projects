using System;

namespace NumberGuesser
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GetAppInfo();
            var name = GetUserName();
            GreetUserName(name);

            var random = new Random();

            var correctNumber = random.Next(1, 11);
            var correctanswer = false;
            Console.WriteLine("Zgadnij liczbe z przedziału od 1 do 10.");

            while (!correctanswer)
            {
                var input = Console.ReadLine();
                int guess;

                var isNumber = int.TryParse(input, out guess);
                if (!isNumber)
                {
                    changeColor(ConsoleColor.Yellow, "Prosze wprowadzić liczbę");
                    continue;
                }

                if (guess < 1 || guess > 10)
                {
                    changeColor(ConsoleColor.Yellow, "Prosze wprowadzić liczbę z przedziału od 1 do 10");
                    continue;
                }

                if (guess < correctNumber)
                {
                    changeColor(ConsoleColor.Red, "Wylosowana liczba jest większa.");
                }
                else if (guess > correctNumber)
                {
                    changeColor(ConsoleColor.Red, "Wylosowana liczba jest mniejsza.");
                }
                else
                {
                    correctanswer = true;
                    changeColor(ConsoleColor.Green, "Brawo prawdiłowa odpowiedź.");
                }
            }
        }

        private static void GetAppInfo()
        {
            var appName = "Zgadywanie liczb";
            var appVersion = 1;
            var appAuthor = "Artur Rezmer";

            var info = $"[{appName}] Wersja 0.0.{appVersion}, Autor: {appAuthor}";
            changeColor(ConsoleColor.Magenta, info);
        }

        private static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię?");
            var inputuserName = Console.ReadLine();
            return inputuserName;
        }

        private static void GreetUserName(string name)
        {
            var greet = $"Powodzenia {name}, odgadnij liczbę...";
            changeColor(ConsoleColor.Blue, greet);
        }

        private static void changeColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}