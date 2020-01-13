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
        }
    }
}
