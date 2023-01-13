using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A Cookie Bank which stores cookies.
/// Authors: Lukasz Bednarek, Jeremy Schmidt
/// Date: January 2021
/// </summary>
namespace Lab01
{
    /// <summary>
    /// A bank storing cookies.
    /// </summary>
    public class CookieBank
    {
        /// <summary>
        /// Integer value of cookies in the bank.
        /// </summary>
        private int count;

        /// <summary>
        /// Contsructs an empty cookie bank.
        /// </summary>
        public CookieBank()
        {
            Count = 0;
        }

        /// <summary>
        /// Public reference for private instance variable: count.
        /// </summary>
        public int Count
        {
            get
            {
                return count;
            }

            private set
            {
                if (value >= 0)
                {
                    count = value;
                }
            }
        }

        /// <summary>
        /// Increment the cookie count of the cookie bank.
        /// </summary>
        public void Click()
        {
            Count++;
        }

        /// <summary>
        /// Extract required cookies for sale item's worth.
        /// </summary>
        /// <param name="saleAmount"> an int </param>
        public bool Purchase(int saleAmount)
        {
            if (Count >= saleAmount) {
                Count -= saleAmount;
                return true;
            } 
            else
            {
                return false;
            }

        }
    }
}
