﻿using System;

namespace Konsool3
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserChoice = string.Empty;
            do
            {
                Console.WriteLine("Enter any number");
                int UserTarget = int.Parse(Console.ReadLine());

                int Start = 0;

                while (Start <= UserTarget)
                {
                    Console.Write(Start + " ");
                    Start = Start + 2;
                }

                do
                {

                    Console.WriteLine("Do you want to continue - Yes or No?");

                    UserChoice = Console.ReadLine().ToUpper();
                    if (UserChoice != "YES" && UserChoice != "NO")
                    {
                        Console.WriteLine("Invalid choice, please say Yes or No");
                    }
                } while (UserChoice != "YES" && UserChoice != "NO");
            } while (UserChoice == "YES"); 
        }
    }
}