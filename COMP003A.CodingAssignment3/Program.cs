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
                        string answer;

                        Console.Write("Enter the name of an expense: ");
                        expense1 = Console.ReadLine();

                        Console.Write("Enter the value of the expense: ");
                        expenseValue1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Expense Added Successfully");

                        Console.Write("Would you like to add another expense?"); // Check if user would like to add another expense
                        answer = Console.ReadLine();
                        if (answer == "Yes")
                        {
                            Console.Write("Enter the name of an expense: ");
                            expense2 = Console.ReadLine();

                            Console.Write("Enter the value of the expense: ");
                            expenseValue2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Expense Added Successfully");
                           
                        }
                        else
                        {
                            break;
                        }
                            break;
                    case 2:
                        Console.WriteLine($"Expenses:\n{expense1} = {expenseValue1}");
                        Console.WriteLine("\n{expense2} = {expenseValue2}");
                        break;
                    case 3:
                        string removal;
                        Console.Write("Which expense would you like to remove?");
                        removal = Console.ReadLine();
                        if (removal == expense1)
                        {
                            expense1 = "Not Added";
                            Console.WriteLine("Expense Successfully Removed.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine("Choice must be between 1 and 4.");
                        break;
                    
         
                }

            }
        }
    }
}

           
