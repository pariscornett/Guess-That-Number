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
            //EDIT 1/19/2020: According to Microsoft documentation, this string interpolation isn't actually correct. It seems like it should be written as follows:
            //Console.WriteLine($"{name} is {age} years old");


            //STARTING POINT

            GetAppInfo();

            GreetUser();

            //Game Rules below

            //Set loop to allow continuous play
            while (true)
            {

                //Randomize "correct" number
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Set user guess (which will be reassigned later)
                int guess = 0;

                //Ask user to guess
                Console.WriteLine("Guess a number between 1 and 10 🧐");

                //Set loop to continue asking user until the correct number is guessed
                while (guess != correctNumber)
                {
                    //Get user input
                    string inputGuess = Console.ReadLine();

                    //Check to make sure user input is actually a number
                    if (!int.TryParse(inputGuess, out guess))
                    {
                        //Print an error message
                        PrintColorMessage(ConsoleColor.Red, "Please input an actual number");

                        //keep going
                        continue;
                    }

                    //reassign user input to variable guess and convert from string to integer
                    guess = Int32.Parse(inputGuess);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                       
                        //Print an error message
                        PrintColorMessage(ConsoleColor.Red, "Sorry, that's the wrong number. Try again");
                    }


                }

                //Send message for correct guess
                PrintColorMessage(ConsoleColor.Cyan, "Congratulations! 🍾 That is the correct number!");

                //Ask to play again
                Console.WriteLine("Do you want to play again? [Y or N]");

                //Get answer (even though we are reading only one character, we will use string instead of char since the chained methods return strings
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Set app variables
            string appName = "Guess That Number";
            string appVersion = "1.0.0";
            string appAuthor = "Astral Plane 💫";

            //Set console text color and print app info to console.
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine($"{appName}: Version {appVersion} by {appAuthor}");

            //Rest text color
            Console.ResetColor();   
        }

        static void GreetUser()
        {
            //Ask user's name
            Console.WriteLine("What's your name?");

            //Store user's name in this variable
            string input = Console.ReadLine();

            //Greet user by name
            Console.WriteLine($"Thanks for joining us, {input}. Let's play a game! 🖥");
        }

        static void PrintColorMessage(ConsoleColor color, string message )
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
