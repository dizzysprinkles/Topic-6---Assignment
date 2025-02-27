using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System;

namespace Topic_6___Assignment
{
    internal class Program
    {
        public static void Prompter()
        {
            int max, min, guess;
            Console.Clear();
            Console.WriteLine("Hi there! I will ask you for a maximum value and a minimum value and then you'll need to pick a number between them!");
            Console.WriteLine("Please give me the maxmimum value: ");
            while (!Int32.TryParse(Console.ReadLine(), out max))
            {
                Console.WriteLine("Invalid maximum. Try again!");
            }
            Console.WriteLine();

            Console.WriteLine("And now for the  minimum value: ");
            while (!Int32.TryParse(Console.ReadLine(), out min) || min >= max)
            {
                Console.WriteLine("Invalid minimum. Try again!");
            }
            Console.WriteLine();
            Console.WriteLine("Now what number would you like to pick that is between them? ");
            while (!Int32.TryParse(Console.ReadLine(), out guess) || guess > max || guess < min)
            {
                Console.WriteLine("Invalid guess. Try again!");
            }
            Console.WriteLine();
            Console.WriteLine($"Awesome! {guess} is between {min} and {max}!");
        }

        public static void Bank()
        {
            string selection = "";
            double deposit, withdrawal, payement, charge, accountBalance, minimumAmount;
            charge = 0.75;
            accountBalance = 150.00;
            


            while (selection != "q" || selection != "quit")
            {
                Console.Clear();
                Console.WriteLine("Welcome to BoB ATM. We charge $0.75 per transaction. \nPlease type the number OR name of the transaction you would like to perform:");
                Console.WriteLine("(Invalid selections will result in balance update. Charges will still be applied)");
                Console.WriteLine();
                Console.WriteLine("1 - Deposit");
                Console.WriteLine("2 - Withdrawal");
                Console.WriteLine("3 - Bill payement");
                Console.WriteLine("4 - Account balance update");
                Console.WriteLine("Q - Quit");
                Console.WriteLine();
                selection = Console.ReadLine().ToLower().Trim();
                Console.WriteLine();
    
                if (selection == "1" || selection == "deposit")
                {
                    Console.WriteLine("You have chosen 1 - Deposit.");
                    Console.WriteLine();
                    Console.WriteLine("How much money would you like to deposit? ");
                    if (!Double.TryParse(Console.ReadLine(), out deposit) || deposit < 0)
                    {
                        accountBalance -= charge;
                        Console.WriteLine();
                        Console.WriteLine("Invalid amount. Transaction fee has been subtracted from your balance.");
                        Console.WriteLine("Your new balance is " + accountBalance.ToString("C"));
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to transaction selection.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        accountBalance = accountBalance - charge + deposit;
                        Console.WriteLine($"Awesome! You deposited {deposit.ToString("C")}. \nWith the subtraction of the transaction fee, you have {accountBalance.ToString("C")} remaining.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to transaction selection.");
                        Console.ReadLine();
                    }

                }
                else if (selection == "2" || selection == "withdrawal")
                {
                    Console.WriteLine("You have chosen 2 - Withdrawal.");
                    Console.WriteLine();
                    Console.WriteLine("How much would you like to withdraw? ");
                    if (!Double.TryParse(Console.ReadLine(), out withdrawal) || withdrawal < 0 || withdrawal > accountBalance-charge)
                    {
                        accountBalance -= charge;
                        Console.WriteLine();
                        Console.WriteLine("Invalid amount. Transaction fee has been subtracted from your balance.");
                        Console.WriteLine("Your new balance is " + accountBalance.ToString("C"));
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to transaction selection.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        accountBalance = accountBalance - charge - withdrawal;
                        Console.WriteLine($"Alright! You withdrew {withdrawal.ToString("C")}. \nWith the subtraction of the transaction fee, you have {accountBalance.ToString("C")} remaining.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to transaction selection.");
                        Console.ReadLine();
                    }

                }
                else if (selection == "3" || selection == "bill payement")
                {
                    Console.WriteLine("You have chosen 3 - Bill payement.");
                    Console.WriteLine();
                    Console.WriteLine("How much is the bill you would like to pay off? ");

                    if (!Double.TryParse(Console.ReadLine(), out payement) || payement < 0 || payement > accountBalance-charge)
                    {
                        accountBalance -= charge;
                        Console.WriteLine();
                        Console.WriteLine("Invalid amount. Transaction fee has been subtracted from your balance.");
                        Console.WriteLine("Your new balance is " + accountBalance.ToString("C"));
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to transaction selection.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine();
                        accountBalance = accountBalance - charge - payement;
                        Console.WriteLine($"Congrats on paying your bills! You paid {payement.ToString("C")}. \nWith the subtraction of the transaction fee, you have {accountBalance.ToString("C")} remaining.");
                        Console.WriteLine();
                        Console.WriteLine("Press ENTER to return to transaction selection.");
                        Console.ReadLine();
                    }

                }
                else if (selection == "4" || selection == "account balance update")
                {
                    Console.WriteLine("You have chosen 4 - Account balance update.");
                    Console.WriteLine();
                    accountBalance -= charge;
                    Console.WriteLine();
                    Console.WriteLine("Transaction fee has been subtracted from your balance.");
                    Console.WriteLine("Your new balance is " + accountBalance.ToString("C"));
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to return to transaction selection.");
                    Console.ReadLine();

                }
                else if (selection == "q" || selection == "quit")
                {
                    Console.WriteLine("Thank you for your patronage at BoB ATM! ");
                    return;
                }
                else
                {
                    accountBalance -= charge;
                    Console.WriteLine("Invalid transaction selection. Transaction fee has been subtracted from your balance.");
                    Console.WriteLine("Your new balance is " + accountBalance.ToString("C"));
                    Console.WriteLine();
                    Console.WriteLine("Press ENTER to return to transaction selection.");
                    Console.ReadLine();
                }

            }
        }

        public static void Dice()
        {
            Console.Clear();
            int numberRolls;
            Die die1, die2;
            die1 = new Die();
            die2 = new Die();
            Console.WriteLine("Hello! In this section, you will roll some dice until you get doubles!");
            Console.WriteLine("Press ENTER to roll your first pair!");
            Console.ReadLine();

            die1.DrawDie();
            die2.DrawDie();
            numberRolls = 1;

            while (die1.Roll != die2.Roll)
            {
                Console.WriteLine("Oops! You didn't roll doubles! Press ENTER to reroll you dice.");
                Console.ReadLine(); 
                die1.RollDie();
                die2.RollDie();
                numberRolls++;
                die1.DrawDie();
                die2.DrawDie();
                Console.WriteLine() ;
            }
            Console.WriteLine($"You got doubles! It took you {numberRolls} roll(s) to get doubles! Congrats!");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            string choice = "";

            while (choice != "q")
            {
                Console.Clear();
                Console.WriteLine("Welcome to Topic 6's Main Menu!  Please select an option to try out:");
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
                    Console.WriteLine();
                    Console.WriteLine("Hit ENTER to return to Main Menu!");
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("You chose option 2 - Banking Machine");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Bank();
                    Console.WriteLine("Hit ENTER to return to Main Menu!");
                    Console.ReadLine();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("You chose option 3 - Doubles Roller");
                    Console.WriteLine("Hit ENTER to continue.");
                    Console.ReadLine();
                    Dice();
                    Console.WriteLine("Hit ENTER to return to Main Menu!");
                    Console.ReadLine();

                }
                else if (choice == "q")
                {
                    Console.WriteLine("Thanks for playing!");
                    return;

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

