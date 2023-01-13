using System;
using System.Windows.Forms;

/// <summary>
/// Event handler of form.
/// Authors: Lukasz Bednarek, Jeremy Schmidt
/// Date: January 2021
/// </summary>
namespace Lab01
{
    public partial class MainForm : Form
    {
        
        /// <summary>
        /// A cookie bank object.
        /// </summary>
        CookieBank cookieBank = new CookieBank();
        Reward fan = new Reward("Fan", 50);

        /// <summary>
        /// Initialize GUI form.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds a cookie to the cookie bank.
        /// </summary>
        /// <param name="sender"> an object </param>
        /// <param name="e"> EventArg(s) </param>
        private void CookieClicker_Click(object sender, EventArgs e)
        {
            cookieBank.Click();
            CookieCount_Update();
        }

        /// <summary>
        /// Update the visual representation of the cookie bank on the form.
        /// 
        /// Credit: https://stackoverflow.com/questions/39280121/c-sharp-refresh-value-on-a-dynamic-label for inspiration and how to update a dynamic value in a label's text
        /// </summary>
        private void CookieCount_Update()
        {
            cookieCount.Text = $"Cookie Bank: {cookieBank.Count}";
            cookieCount.Update(); // update label after new text
        }

        /// <summary>
        /// Display appliance rewards when checked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AppliancesCategory_CheckedChanged(object sender, EventArgs e)
        {
            buyAppliance1.Visible = !buyAppliance1.Visible; // appliances rewards become visible or not when button is changed (on/off)
            applianceName1.Visible = !applianceName1.Visible;
            appliancePrice1.Visible = !appliancePrice1.Visible;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            warning.Visible = false;
            applianceName1.Text = fan.Name;
            appliancePrice1.Text = $"{fan.Price} Cookies";
            applianceName1.Update();
        }

        /// <summary>
        /// Buy top appliance reward.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buyAppliance1_Click(object sender, EventArgs e)
        {
            Buy_reward(fan);
        }

        /// <summary>
        /// Process a purchase of a reward.
        /// </summary>
        /// <param name="purchase"></param>
        private void Buy_reward(Reward purchase)
        {
            if (cookieBank.Purchase(purchase.Price)) // evaluate if purchase is possible, if it is cookies are deducted from bank
            {
                CookieCount_Update();
                warning.Visible = false;
                buyAppliance1.Visible = false;
            }
            else
            {
                warning.Visible = true;
            }
        }
    }
}
