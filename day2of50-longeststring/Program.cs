using System;

namespace day2of50_longeststring
{
    class Program
    {
        static void Main(string[] args)
        {
            AppGetInfo();


            // ask user for a sentence
            PrintColorMessage(ConsoleColor.Red, "Please write a sentece.");

            string inputSentence = Console.ReadLine();

            string[] words = inputSentence.Split(" ");

            int value = 0;

            string longestString = "";

            foreach (var word in words)
            {
                if (word.Length > value ) {
                    longestString = word;
                    value = word.Length;
                }
            }

            Console.WriteLine("The longest string in the sentence is: {0}", longestString);



        }

        static void AppGetInfo() {
            string appName = "Day 2/50 - The Longest String";
            string appVersion = "1.0.0";
            string appAuthor = "Code Morning Snack";

           
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("App:{0} | Version:{1} | Author:{2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
