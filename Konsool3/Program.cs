using System; // setting up the usage of the system duh

namespace Konsool3 // setting up the namespace
{
    class Program // setting up the class
    {
        static void Main(string[] args) // setting up the local method 
        {
            string UserChoice = string.Empty; // read-only string
            do
            {
                Console.WriteLine("Enter any number"); // displaying text in the console
                int UserTarget = int.Parse(Console.ReadLine()); // reading the input from the console

                int Start = 0; // setting up the value type of start

                while (Start <= UserTarget) // setting up continuous activity 
                {
                    Console.Write(Start + " "); // displaying text in console
                    Start = Start + 2; // doing the maths
                }

                do // setting up do-loop block
                {

                    Console.WriteLine("Do you want to continue - Yes or No?"); //displaying text in console

                    UserChoice = Console.ReadLine().ToUpper(); //reading the input from the console - converting it to all capital
                    if (UserChoice != "YES" && UserChoice != "NO") // if statement - boolean and operator
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No"); // false statement
                    }
                } while (UserChoice != "YES" && UserChoice != "NO"); // continuous activity of boolean operator
            } while (UserChoice == "YES"); // looping back to start
        }
    }
}