//Author: Michael Baker
//Course: COMP-003A
//Faculty: Jonathan Cruz
//Purpose: Budget management application demonstrating control flow


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

            // Create menu and ask for user input

            int menuChoice;
            while (true)
            {
                Console.WriteLine("1. Add an Expense.\n");
                Console.WriteLine("2. View Expenses and Budget.\n");
                Console.WriteLine("3. Remove an Expense.\n");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your choice number: ");
                menuChoice = int.Parse(Console.ReadLine());

                try
                {
                    if (menuChoice <= 0) throw new Exception("Number must be 1 through 4.");
                    if (menuChoice > 4) throw new Exception("Number must be 1 through 4.");
                    break;
                }

                catch (Exception ex)
                {
                    Console.WriteLine($"Invalid input: {ex.Message}\n Please try again.");
                }
            }
            string expense1;
            string expense2;
            string expense3;
            string expense4;
            string expense5;
            int expense1Value;
            int expense2Value;
            int expense3Value;
            int expense4Value;
            int expense5Value;


            // First menu popup
            if (menuChoice == 1);
            {
                Console.Write("Name of the Expense: ");
                expense1 = Console.ReadLine();
                Console.Write("Enter the expense amount: ");
                expense1Value = int.Parse(Console.ReadLine());
                Console.WriteLine("Expense added successfully!");

            }
        }
    }
}
