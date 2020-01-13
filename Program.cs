 using System;

// Namespace (keeps things organized)
namespace GuessThatNumber
{
    //Main Class
    class Program
    {
        // Entry Point Method
        static void Main(string[] args)
        {
            //A few C# notes before getting started
            //string name = "Paris Cornett";
            //int age = 26;

            //Console.WriteLine(name + " is " + age + " years old 👑" );
            //Line 16 works fine, but the better way to write this would be as follows:
            //Console.WriteLine("{0} is {1} years old 👩🏻‍💻", name, age);
            //if you wanted to add more variables, you would add more numbered brackets (in ascending order) and more variable names outside of quotations.

            //STARTING POINT

            //Set app variables
            string appName = "Guess That Number";
            string appVersion = "1.0.0";
            string appAuthor = "Astral Plane 💫";

            //Set console text color and print app info to console.
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Rest text color
            Console.ResetColor();

            //Ask user's name
            Console.WriteLine("What's your name?");

            //Store user's name in this variable
            string input = Console.ReadLine();

            //Greet user by name
            Console.WriteLine("Thanks for joining us, {0}. Let's play a game! 🖥", input);

            //Game Rules below

            //Set correct number
            int correctNumber = 7;

            //Set user guess (which will be reassigned later)
            int guess = 0;

            //Ask user to guess
            Console.WriteLine("Guess a number between 1 and 10 🧐");

            //Set loop to continue asking user until the correct number is guessed
            while(guess != correctNumber)
            {
                //Get user input
                string inputGuess = Console.ReadLine();

                //Check to make sure user input is actually a number
                if(!int.TryParse(inputGuess, out guess))
                {
                    //Send user an error message
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please input a number");
                    Console.ResetColor();

                    //keep going
                    continue;
                }

                //reassign user input to variable guess and convert from string to integer
                guess = Int32.Parse(inputGuess);

                //match guess to correct number
                if(guess != correctNumber)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Sorry, {0}, that's the wrong number. Try again", input);
                    Console.ResetColor();
                }


            }

            //Set output for correct guess
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Congratulations! 🍾 That is the correct number!");
            Console.ResetColor();
        }
    }
}
