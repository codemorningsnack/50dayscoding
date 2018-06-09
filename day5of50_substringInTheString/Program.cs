using System;

namespace day5of50_substringInTheString
{
    class Program
    {
        static void Main(string[] args)
        {
            // get info App
            AppGetInfo();

            // ask user for a sentence - String
            PrintColorMessage(ConsoleColor.Cyan, "Please write a sentence.");
            string sentence = Console.ReadLine();

            // ask user for a word to check if there is in the sentence
            PrintColorMessage(ConsoleColor.Cyan, "Great! Now please give me a word");
            string word = Console.ReadLine();

            // split the sentence in an array
            string[] sentenceSplitted = sentence.Split(" ");

            // declaring a boolean var as a status
            bool exists = false;

            // looping through the senteceSplitted to check if the substring exists.
            // if so exists will be true
            foreach (var aString in sentenceSplitted)
            {
                if (aString == word)
                {
                    exists = true;
                    break;
                }
            }

            // showing messages depending the exists value (true ou false)
            if (exists)
            {
                PrintColorMessage(ConsoleColor.Green, "Oh yeah. There is your word in your sentence");
            }
            else
            {
                PrintColorMessage(ConsoleColor.Red, "Ups... There is NOT your word in your sentence");
            }




        }

        static void AppGetInfo(){
            string appName = "Substring in the String.";
            string appVersion = "1.0.0";
            string appAuthor = "Code Morning Snack";

            Console.WriteLine("App: {0} | Version: {1} | Author: {2}", appName, appVersion, appAuthor);
        }

        static void PrintColorMessage(ConsoleColor color, string message) {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
