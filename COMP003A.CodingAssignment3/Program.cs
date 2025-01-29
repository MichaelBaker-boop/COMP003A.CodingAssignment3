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
            int income;
            Console.Write("Enter your monthly income: ");
            income = int.Parse(Console.ReadLine());

            Console.WriteLine("1. Add an Expense.\n");
            Console.WriteLine("2. View Expenses and Budget.\n");
            Console.WriteLine("3. Remove an Expense.\n");
            Console.WriteLine("4. Exit");
        }
    }
}
