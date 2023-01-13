using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// A purchasable reward.
/// Authors: Lukasz Bednarek, Jeremy Schmidt
/// </summary>
namespace Lab01
{
    class Reward
    {
        private String name;
        private int price;

        public Reward(String name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public String Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Trim().Length > 1)
                {
                    name = value;
                }
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                {
                    price = value;
                }
            }
        }
    }

}
