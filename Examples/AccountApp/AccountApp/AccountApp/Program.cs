using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Lab 1 Example 
/// Include here the authors:
/// Include here date/revisions:
/// Source:
/// </summary>
namespace AccountApp
{
    /// <summary>
    /// Constants definition
    /// </summary>
    static class Constants
    {
        public const decimal InitialChequing = 50.00m;
        public const decimal InitialSavings = 0.00m;
    }
    /// <summary>
    /// Console application
    /// Entering deposit amounts and displaying the balance 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Account accountChequing = new Account("Chequing", Constants.InitialChequing);
            Account accountSevings = new Account("Savings", Constants.InitialSavings);

            Console.WriteLine(
               $"{accountChequing.Type} balance: {accountChequing.Balance:C}"); // Writes Chequing Balance on console
            Console.WriteLine(
               $"{accountSevings.Type} balance: {accountSevings.Balance:C}"); // Writess Savings balance on console

            Console.Write("\nEnter deposit amount for your Chequing account: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine()); // Parses a number. String is unhandled
            Console.WriteLine(
               $"adding {depositAmount:C} to account Chequing balance\n");
            accountChequing.Deposit(depositAmount); // add money to chequing balance


            Console.WriteLine(
               $"{accountChequing.Type} balance: {accountChequing.Balance:C}");
            Console.WriteLine(
               $"{accountSevings.Type} balance: {accountSevings.Balance:C}");


            Console.Write("\nEnter deposit amount for your Savings account: ");
            depositAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine(
               $"adding {depositAmount:C} to Savings balance\n");
            accountSevings.Deposit(depositAmount); // add money to savings balance


            Console.WriteLine(
               $"{accountChequing.Type} balance: {accountChequing.Balance:C}");
            Console.WriteLine(
               $"{accountSevings.Type} balance: {accountSevings.Balance:C}");
            Console.ReadLine(); // does this so user has the change to see new balances
        }
    }
}
