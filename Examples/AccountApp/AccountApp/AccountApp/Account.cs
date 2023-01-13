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
    /// Account class with two methods: balance and deposit
    /// </summary>
    class Account
    {
        /// <summary>
        /// Public auto-implemented property
        /// </summary>
        public string Type { get; set; }
        
        /// <summary>
        /// Private instance variable
        /// </summary>
        private decimal balance; 

        // constructor with two parameters  
        public Account(string accountType, decimal initialBalance)
        {
            Type = accountType;
            Balance = initialBalance; // Balance's set accessor 
        }

        /// <summary>
        /// Balance property get and set implementation. Includes validation
        /// </summary>
        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set // can be used only within the class
            {
                // validate that the balance is greater than 0.0; if it's not,
                // instance variable balance keeps its prior value
                if (value > 0.0m) // m indicates that 0.0 is a decimal literal
                {
                    balance = value;
                }
            }
        }

        /// <summary>
        /// Deposit method
        /// </summary>
        /// <param name="depositAmount"></param>
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m) // if the depositAmount is valid
            {
                Balance = Balance + depositAmount; // add it to the balance 
            }
        }
    }

}
