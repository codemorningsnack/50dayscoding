using System;

namespace day4of50_sumofarray
{
    class Program
    {
        static void Main(string[] args)
        {
            // call function to show the info of the app
            AppGetInfo();

            // ask user how many elements he wants to create an array and save the number in a var called numberElements
            PrintColorMessage(ConsoleColor.Cyan, "How many elements do you want in your array?");
            int numberElements = Convert.ToInt32(Console.ReadLine());

            // declaring array with the number of elements
            int[] array = new int[numberElements];


            int counter = 0;

            Console.WriteLine("the array length is: " + array.Length);
            // ask user to fill the array
            while (counter < array.Length)
            {
                PrintColorMessage(ConsoleColor.Cyan, "please insert a number");
                array[counter] = Convert.ToInt32(Console.ReadLine());
                counter++;

            }


            foreach (var value in array)
            {
                Console.WriteLine(value);
            }

            // calculate the sum of elements of the declared array

            int result = 0;
            foreach (var value in array)
            {
                result += value;
            }


            // printing the result
            PrintColorMessage(ConsoleColor.Yellow, "The result is: " + result);

        }



        // function to print a message in a color was sent as a parameter

        static void PrintColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // function to show the header of the console application - info
        static void AppGetInfo() {
            string appName = "Sum of array from the user";
            string appVersion = "1.0.0.";
            string appAuthor = "Code Morning Snack";

            Console.WriteLine("App: {0} | Version: {1} | Author: {2}", appName, appVersion, appAuthor);
        }
    }
}
