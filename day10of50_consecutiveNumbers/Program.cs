using System;

namespace day10of50_consecutiveNumbers
{
    class Program
    {
        static void Main(string[] args)
        {


            // Write a program to work out if a series of 5 digits are consecutive numbers.

            // declare an array to store the numbers
            int[] numbers = new int[5];



            // ask five numbers to user
            Console.WriteLine("Please insert five numbers and I'll tell you if they are consecutive or not.");
            for (int i = 0; i < numbers.Length; i++) {

                Console.WriteLine("Insert a number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }


            // declare a boolean var to the result
            bool result = true;

            // declare sort variable
            string orderBy = "ascending";

            // verify if is ascending or descending
            if (numbers[0] > numbers[1])
            {
                orderBy = "descending";
            }


            // iterate the array and check if they are consecutive numbers
            for (int c = 0; c < numbers.Length - 1; c++)
            {
                if (orderBy == "ascending")
                {
                    if (numbers[c] != numbers[c + 1] - 1)
                    {
                        result = false;
                    }

                }

                if (orderBy == "descending")
                {
                    if (numbers[c] != numbers[c + 1] + 1)
                    {
                        result = false;
                    }
                }
            }


          
            // show the result
            Console.WriteLine("Consecutive numbers:{0}", result);


        }
    }
}
