using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.ForegroundColor = ConsoleColor.Green;
            GetAppInfo();
            Console.ResetColor();


            // ask the name of the user
            Console.WriteLine("W E L C O M E ! What's your name?");

            // save the input to a var called inputName
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game.",inputName);






            // create a random object
            Random random = new Random();

            int correctNumber = random.Next(1, 10);


            // init guess var
            int guess = 0;

           
            // ask for a number
            Console.WriteLine("Please enter a number.");



            while (guess != correctNumber)
            {


                string input = Console.ReadLine();


                // make sure its a number
                if (!int.TryParse(input, out guess))
                {
                    PrintColorMEssage(ConsoleColor.Magenta, "Please enter an actual number.");

                    continue;
                }

                guess = Int32.Parse(input);

                if (guess != correctNumber) {

                    PrintColorMEssage(ConsoleColor.Red, "Wrong number, please try another one.");
                
                }



                continue;
            }

            PrintColorMEssage(ConsoleColor.Yellow, "You're Correct.");
          

        }


        // declaring app header info
        static void GetAppInfo() 
        {
            string nameApp = "Number Guesser";
            string versionApp = "1.0.0";
            string authorApp = "Luís Almeida";

            Console.WriteLine("App:{0} | Version:{1} | Made with <3 by {2}", nameApp, versionApp, authorApp);
        }


        static void PrintColorMEssage(ConsoleColor color, string message){
          
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
            
        }
    }
}
