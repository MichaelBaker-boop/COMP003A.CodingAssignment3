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
            string expense1 = "N/A";
            string expense2;
            string expense3;
            string expense4;
            string expense5;
            int expenseValue1 = 0;
            int expenseValue2;
            int expenseValue3;
            int expenseValue4;
            int expenseValue5;

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
               
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the name of an expense: ");
                        expense1 = Console.ReadLine();
                        Console.Write("Enter the value of the expense: ");
                        expenseValue1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Expense Added Successfully");
                        break;
                    case 2:
                        Console.WriteLine($"Expenses:\n{expense1} = {expenseValue1}");
                        break;
                    case 3:
                        Console.WriteLine("You chose 3.");
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

           
