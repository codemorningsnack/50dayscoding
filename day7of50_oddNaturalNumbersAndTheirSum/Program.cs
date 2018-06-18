using System;

namespace day7of50_oddNaturalNumbersAndTheirSum
{
    class Program
    {
        static void Main(string[] args)
        {
            // calling function to show the app header
            GetInfoApp();

            // ask user for a number
            PrintingColorMessage(ConsoleColor.Yellow, "Please insert a number.");

            // convert the user input to a int number (was introduced as a string)
            // store the number to a declared int variable - n
            int n = Convert.ToInt32(Console.ReadLine());

            // initialize the c variable as 0, which will be used as counter
            int c = 1;

            int[] oddNumbers = new int[n];

            // iterating all the numbers between 0 and the N - number introduced
            // by the user
            while (c <= n)
            {
                
                // check if the number is odd
                if (c % 2 == 1)
                {
                    // store the odd number into the array
                    oddNumbers[c-1] = c;

                }

                // incrementing a value to C
                c = c + 1;

            }

            int sum = 0;

            // iterating the array and showing the element wchich are different of 0
            foreach (var oddNumber in oddNumbers)
            {
                // checking if the oddNumber is different of 0
                if (oddNumber != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(oddNumber);
                    Console.ResetColor();
                    sum = sum + oddNumber;
                }
            }

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("The sum of the odd numbers is {0}", sum);
           

        }

        static void GetInfoApp(){
            
            // string names to use on the info app message - header
            string appName = "Odd Numbers and their Sum";
            string appVersion = "1.0.0";
            string appAuthor = "Code Morning Snack";

            // changing the font color to green
            Console.ForegroundColor = ConsoleColor.Green;

            // displaying the header message
            Console.WriteLine("App: {0} | Version: {1} | Author: {2}", appName, appVersion, appAuthor);

            // resetting the font color to the default color of the application
            Console.ResetColor();

        }

        static void PrintingColorMessage(ConsoleColor color, string message){

            Console.ForegroundColor = color;

            Console.WriteLine(message);

            Console.ResetColor();
        }
    }


}
