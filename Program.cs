namespace Topic_6___Assignment
{
    internal class Program
    {
        public static void Prompter(int max, int min)
        {

        }

        public static void Bank(string selection, double amount)
        {

        }

        public static void Dice()
        {

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
                    Console.WriteLine("You chose option 1");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {


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

