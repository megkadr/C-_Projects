using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            string name = GetUserName();
            GreetUserName(name);

            Random random = new Random();

            int correctNumber = random.Next(1,11);
            bool correctanswer = false;
            Console.WriteLine("Zgadnij liczbe z przedziału od 1 do 10.");

            while(!correctanswer)
            {
                string input = Console.ReadLine();
                int guess;

                bool isNumber =int.TryParse(input, out guess);
                if (!isNumber)
                {
                    changeColor(ConsoleColor.Yellow, "Prosze wprowadzić liczbę");
                    continue;

                }
                if(guess< 1 || guess>10)
                {
                    changeColor(ConsoleColor.Yellow, "Prosze wprowadzić liczbę z przedziału od 1 do 10");
                    continue;
                }
                if (guess < correctNumber)
                {
                    changeColor(ConsoleColor.Red, "Wylosowana liczba jest większa.");                 
                }
                else if(guess > correctNumber)
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
        static void GetAppInfo()
        {
            string appName = "Zgadywanie liczb";
            int appVersion = 1;
            string appAuthor = "Artur Rezmer";

           string info = $"[{appName}] Wersja 0.0.{appVersion}, Autor: {appAuthor}";
           changeColor(ConsoleColor.Magenta, info);
        }
        static string GetUserName()
        {
            Console.WriteLine("Jak masz na imię?");
            string inputuserName = Console.ReadLine();
            return inputuserName;
        }
        static void GreetUserName(string name)
        {
            string greet = $"Powodzenia {name}, odgadnij liczbę...";
            changeColor(ConsoleColor.Blue, greet);
        }
        static void changeColor(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
