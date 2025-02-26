using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;

namespace Topic_6___Assignment
{
    internal class Program
    {
        public static void Prompter()
        {
            int max, min;
            Console.WriteLine("Give me a maxmimum value");
            Int32.TryParse(Console.ReadLine(), out max);
            Console.WriteLine("Max is " + max);
            // Check for if min is biiger than max or if max is smaller than min (which ever is asked first)
            // Take in min, max
            // Ask for ## between values, inclusive, integers
            // Keep going until user inputs a correct number


        }

        public static void Bank(string selection, double amount)
        {
            //QUIT,  Transaction options - Deposit, withdrawal, bill payement, account balance update - in invalid, assume account balance update
            // .75 per transaction
        }

        public static void Dice()
        {
            // Dice class from before 
            // Separate the displaying of each roll of the two dice using some blank space or 
            //requiring an ENTER press. Make sure to draw each roll set. At the end, print the number of rolls that
            //were required to get doubles.
        }

        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Topic 6's menu!  Please select an option to try out:");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Banking Machine");
                Console.WriteLine("3 - Doubles Roller");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                choice = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();

                if (choice == "1")
                {
                    Console.WriteLine("You chose option 1 - Prompter");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Prompter();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2 - Banking Machine");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose option 3 - Doubles Roller");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();

                }

                else
                {
                    Console.WriteLine("Invalid choice! Press ENTER to return the main menu.");
                    Console.ReadLine();
                }
            }
        }
    }
}

