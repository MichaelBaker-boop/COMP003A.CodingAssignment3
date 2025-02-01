//Author: Michael Baker
//Course: COMP-003A
//Faculty: Jonathan Cruz
//Purpose: Budget management application demonstrating control flow


using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace COMP003A.CodingAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Budget Management Tool!");
            int income; // The value of the Users income

            while (true)
            {

                //try-catch block to handle invalid input

                try
                {
                    // Prompt user to input income
                    Console.Write("Enter your monthly income: ");
                    // Parse input to integer
                    income = int.Parse(Console.ReadLine());
                    // Check if number is positive
                    if (income <= 0) throw new Exception("Number must be more than zero.");
                    // Exit loop with valid input
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}\n Please try again.");
                }
            }
            string expense1 = "Not Added";
            string expense2 = "Not Added";
            string expense3 = "Not Added";
            string expense4 = "Not Added";
            string expense5 = "Not Added";
            int expenseValue1 = 0;
            int expenseValue2 = 0;
            int expenseValue3 = 0;
            int expenseValue4 = 0;
            int expenseValue5 = 0;

            bool menu = true;
            while (menu)
            {
                // Create a menu and ask for choice from user
                Console.WriteLine("Menu:");
                Console.WriteLine("1) Add an expense.");
                Console.WriteLine("2) View expenses and budget.");
                Console.WriteLine("3) Remove an expense.");
                Console.WriteLine("4) Exit.");

                int choice = int.Parse(Console.ReadLine());

                switch (choice) // Switch Block Based on user choice
                {
                    case 1: // Enter a new expense
                        if (expense1 == "Not Added")
                        {
                            Console.Write("Enter  the name of the expense: ");
                            expense1 = Console.ReadLine();

                            Console.Write("Enter the value of the expense: ");
                            expenseValue1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Expense Added Successfully.");

                        }
                        else
                        {
                            if (expense2 == "Not Added")
                            {
                                Console.Write("Enter  the name of the expense: ");
                                expense2 = Console.ReadLine();

                                Console.Write("Enter the value of the expense: ");
                                expenseValue2 = int.Parse(Console.ReadLine());

                                Console.WriteLine("Expense Added Successfully.");
                            }
                            else
                            {
                                if (expense3 == "Not Added")
                                {
                                    Console.Write("Enter  the name of the expense: ");
                                    expense3 = Console.ReadLine();

                                    Console.Write("Enter the value of the expense: ");
                                    expenseValue3 = int.Parse(Console.ReadLine());

                                    Console.WriteLine("Expense Added Successfully.");
                                }
                                else
                                {
                                    if (expense4 == "Not Added")
                                    {
                                        Console.Write("Enter  the name of the expense: ");
                                        expense4 = Console.ReadLine();

                                        Console.Write("Enter the value of the expense: ");
                                        expenseValue4 = int.Parse(Console.ReadLine());

                                        Console.WriteLine("Expense Added Successfully.");
                                    }
                                    else
                                    {
                                        if (expense5 == "Not Added")
                                        {
                                            Console.Write("Enter  the name of the expense: ");
                                            expense5 = Console.ReadLine();

                                            Console.Write("Enter the value of the expense: ");
                                            expenseValue5 = int.Parse(Console.ReadLine());

                                            Console.WriteLine("Expense Added Successfully.");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Sorry. Only 5 expenses can be saved at once.\n Please delete an expense to add another.");
                                        }
                                    }

                                }
                            }
                        }


                            break;
                    case 2:// Display of expenses and calculation of budget
                        Console.WriteLine($"Expenses:\n{expense1} = {expenseValue1}");
                        Console.WriteLine($"{expense2} = {expenseValue2}");
                        Console.WriteLine($"{expense3} = {expenseValue3}");
                        Console.WriteLine($"{expense4} = {expenseValue4}");
                        Console.WriteLine($"{expense5} = {expenseValue5}");
                        int totalExpenses = expenseValue1 + expenseValue2 + expenseValue3 + expenseValue4 + expenseValue5; // Calculate Total Expenses
                        int totalBudget = income - totalExpenses; // Calculate Remaining Budget

                        Console.WriteLine($"Total Expenses: ${totalExpenses}\nRemaining Budget: ${totalBudget}.");

                        break;
                    case 3: // Block of Code to check which expense to remove
                        string removal;
                        Console.Write("Which expense would you like to remove? ");
                        removal = Console.ReadLine();
                        if (removal == expense1)
                        {
                            expense1 = "Not Added";
                            expenseValue1 = 0;
                            Console.WriteLine("Expense Successfully Removed.");
                        }
                        if (removal == expense2)
                        {
                            expense2 = "Not Added";
                            expenseValue2 = 0;
                            Console.WriteLine("Expense Successfully Removed.");
                        }
                        if (removal == expense3)
                        {
                            expense3 = "Not Added";
                            expenseValue3 = 0;
                            Console.WriteLine("Expense Successfully Removed.");
                        }
                        if (removal == expense4)
                        {
                            expense4 = "Not Added";
                            expenseValue4 = 0;
                            Console.WriteLine("Expense Successfully Removed.");
                        }
                        if (removal == expense5)
                        {
                            expense5 = "Not Added";
                            expenseValue5 = 0;
                            Console.WriteLine("Expense Successfully Removed.");
                        }

                        break;
                    case 4:// Exits the code
                        Console.WriteLine("Goodbye!");
                        menu = false;
                        break;
                    default:// Prompts user to pick one of the available choices
                        Console.WriteLine("Choice must be between 1 and 4.");
                        break;
                    
         
                }

            }
        }
    }
}

           
