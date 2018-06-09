using System;

namespace day6of6_printingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            AppGetInfo();

            PrintingColorMessage(ConsoleColor.Yellow, "What's the width of your triangle?");

            string widthString = Console.ReadLine();

            int widthNumber = Convert.ToInt32(widthString);

            Console.WriteLine("the number is:" + widthNumber);
            // prepare string to shor the first line of triangle
            string line = "";


            int c = 0;
            int j = 0;

            while (c <= widthNumber)
            {
                while(j < c){
                    line = line + widthString;
                    j++;
                }
                c++;
                Console.WriteLine(line);

            }

           

        }



        static void PrintingColorMessage(ConsoleColor color, string message){

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }

        static void AppGetInfo() {

            string appName = "Printing Triangle";
            string appVersion = "1.0.0.";
            string appAuthor = "Code Morning Snack";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("App: {0} | Version: {1} | Author: {2}", appName, appVersion, appAuthor);
            Console.ResetColor();

        }
    }
}
