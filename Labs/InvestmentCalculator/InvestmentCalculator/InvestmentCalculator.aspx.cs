using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

/// <summary>
/// Lab 7 - ASP.net webform of a investment calculator app.
/// Author: Lukasz Bednarek
/// Date: March 30, 2022
/// </summary>
namespace InvestmentCalculator
{

    /// <summary>
    /// Definitions of constant values.
    /// </summary>
    static class Constants
    {
        //Default values to place upon clear button call
        public const double DefaultAnnualInvestmentRate = 2.5;
        public const int DefaultNumOfYears = 20;
        public const string DefaultFutureValue = "...";

        //modifiers to change input values for calculation
        public const int MonthsInAYear = 12;
        public const int RateFromPercentage = 100;
    }

    /// <summary>
    /// A calculator interface which calculates an investment over a period of time with monthly contributions and investment rate.
    /// </summary>
    public partial class InvestmentCalculator : System.Web.UI.Page
    {
        decimal futureValue;

        /// <summary>
        /// Initializes instance on page initialization (only once).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Init(object sender, EventArgs e)
        {
            futureValue = 0;
        }

        /// <summary>
        /// On page render, initializes control properties.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            UnobtrusiveValidationMode = System.Web.UI.UnobtrusiveValidationMode.None;
            if (!IsPostBack)
                for (int i = 50; i <= 500; i += 50)
                    monthlyInvestmentOptionDropdown.Items.Add(i.ToString());
        }

        /// <summary>
        /// Calculates future money value based on monthly investment, annual interest rate, and number of years.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonCalculate(object sender, EventArgs e)
        {
            if (IsValid)
            {
                //init local variables for reference
                int annualInvestment = Int32.Parse(monthlyInvestmentOptionDropdown.SelectedValue) * Constants.MonthsInAYear;
                decimal annualInvestmentRate = decimal.Parse(investmentRateTextBox.Text) / Constants.RateFromPercentage;
                int years = Int32.Parse(yearsTextBox.Text);

                for (int i = 0; i < years; ++i) //use this forumla every year
                {
                    futureValue = (futureValue + annualInvestment) * (1 + annualInvestmentRate);
                }
                //Credit: https://stackoverflow.com/questions/105770/net-string-format-to-add-commas-in-thousands-place-for-a-number, Seibar
                valueLabel.Text = String.Format("${0:N}", futureValue);
            }
        }

        /// <summary>
        /// Resets the monthly investment, annual interest rate, and number of years to their default values.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ButtonClear(object sender, EventArgs e)
        {
            investmentRateTextBox.Text = Constants.DefaultAnnualInvestmentRate.ToString();
            yearsTextBox.Text = Constants.DefaultNumOfYears.ToString();
            valueLabel.Text = Constants.DefaultFutureValue;
        }
    }
}