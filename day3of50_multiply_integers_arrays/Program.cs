using System;

namespace day3of50_multiply_integers_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // call function AppGetInfo
            AppGetInfo();


            // declaring to arrays of values
            int[] firstGroup = new int[4];
            int[] secondGroup = new int[4];

            // init counter as 0
            int counter = 0;



            // ask user for the first group - each group MUST have 4 elements
            PrintColorMessage(ConsoleColor.Yellow, "At first, we need the first group of 4 elements");
            while (counter < firstGroup.Length)
            {
                Console.WriteLine("Please insert a number.");
                int value = Convert.ToInt32(Console.ReadLine());

                firstGroup[counter] = value;
                counter++;
            }

            counter = 0;

            // ask user for the second group - each group MUST have 4 elements
            PrintColorMessage(ConsoleColor.Yellow, "Thanks. Now we need the values to the second group.");
            while (counter < secondGroup.Length)
            {
                Console.WriteLine("Please insert a number.");
                int value = Convert.ToInt32(Console.ReadLine());

                secondGroup[counter] = value;
                counter++;
            }

            int[] result = new int[4];


            // multiplying the respective numbers from the two groups
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = firstGroup[i] * secondGroup[i];

            }

            // print the result
            foreach (var value in result)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The result is: {0}", value);
                Console.ResetColor();

            }

        }
         




        static void AppGetInfo(){
            string appName = "Multiplying integers of two arrays";
            string appVersion = "1.0.0";
            string appAuthor = "Code Morning Snack";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("App:{0} | Version:{1} | Author:{2}", appName, appVersion, appAuthor);
            Console.ResetColor();
        }

        static void PrintColorMessage(ConsoleColor color, string message){
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
