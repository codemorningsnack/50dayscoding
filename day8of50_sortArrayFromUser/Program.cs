using System;

namespace day8of50_sortArrayFromUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // ask and store the number of elements to save on the array
            PrintingColorMessage(ConsoleColor.Cyan, "How many elements will be in your array?");

            // save user value to N as integer
            int n = Convert.ToInt32(Console.ReadLine());

            // create an array with N indexes
            int[] userArray = new int[n];

            int c = 1;

            // fill the array with user inputs
            while (c <= userArray.Length)
            {
                PrintingColorMessage(ConsoleColor.Yellow, "Please insert a number.");
                userArray[c-1] = Convert.ToInt32(Console.ReadLine());
                c++;
            }


            // temporary variable



            int[] sortedArray = new int[n];

            // sort the array


            for (int i = 0; i < userArray.Length - 1; i++)
            {


                for (int x = 0; x < userArray.Length - 1; x++)
                {
                    if (userArray[x] > userArray[x + 1])
                    {
                        int t = userArray[x + 1];
                        userArray[x + 1] = userArray[x];
                        userArray[x] = t;
                    }
                }


            }  

         

             // showing values on the array
            foreach (var number in userArray)
            {
                Console.WriteLine(number);
            }


        }

        static void AppGetInfo() {
            
            string appName = "Sort Array";
            string appVersion = "1.0.0";
            string appAuthor = "Code Morning Snack";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("App: {0} | Version: {1} | Author: {2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }



        static void PrintingColorMessage(ConsoleColor color, string message){

            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();

        }
    }
}
