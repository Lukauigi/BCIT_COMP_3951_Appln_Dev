using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        bool ToggleOff = false; //set false so all btns start disbaled
        float HoldNum;
        float CurrentNum;
        string Opperator;
        public Form1()
        {
            InitializeComponent();
            TogglePower();
        }

        // -------- On/Off Button ----------- //

        /// <summary>
        /// Enables or disables all buttons
        /// </summary>
        private void TogglePower()
        {
            //changes so that one press can toggle on off
            if (ToggleOff == false)
            {
                ToggleOff = true;
                buttonOff.Text = "On";
            }
            else
            {
                ToggleOff = false;
                buttonOff.Text = "Off";
            }

            if (ToggleOff == true)
            {
                button0.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
                buttonPeriod.Enabled = false;
                buttonPosNeg.Enabled = false;

                buttonMemC.Enabled = false;
                buttonMemR.Enabled = false;
                buttonMemS.Enabled = false;
                buttonMemPlus.Enabled = false;

                buttonDivide.Enabled = false;
                buttonSQRT.Enabled = false;
                buttonMultiply.Enabled = false;
                buttonPercent.Enabled = false;
                buttonSubtract.Enabled = false;
                buttonOneOver.Enabled = false;
                buttonAddition.Enabled = false;
                buttonPowerTwo.Enabled = false;

                buttonCE.Enabled = false;
                buttonC.Enabled = false;
                buttonBackspace.Enabled = false;
                buttonEqual.Enabled = false;
            }
            else
            {
                button0.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
                buttonPeriod.Enabled = true;
                buttonPosNeg.Enabled = true;

                buttonMemC.Enabled = true;
                buttonMemR.Enabled = true;
                buttonMemS.Enabled = true;
                buttonMemPlus.Enabled = true;

                buttonDivide.Enabled = true;
                buttonSQRT.Enabled = true;
                buttonMultiply.Enabled = true;
                buttonPercent.Enabled = true;
                buttonSubtract.Enabled = true;
                buttonOneOver.Enabled = true;
                buttonAddition.Enabled = true;
                buttonPowerTwo.Enabled = true;

                buttonCE.Enabled = true;
                buttonC.Enabled = true;
                buttonBackspace.Enabled = true;
                buttonEqual.Enabled = true;
            }
        }
        /// <summary>
        /// Turns the calculator on when the Off button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOff_Click(object sender, EventArgs e)
        {
            TogglePower();
            
        }

        // -------- Numbers, Period, Pos/Neg ----------- //

        /// <summary>
        /// Handles the click event for numbers 0-9 and period
        /// Updates the textbox to show the new value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            textBox.Text = "" + CurrentNum;
            Button btn = (Button)sender;
            if (textBox.Text == "0") //ensures 0 isnt appended to the front of the number
            {
                textBox.Text = btn.Text; //update the textbox
                CurrentNum = float.Parse(textBox.Text);
            }
            else
            {
                textBox.Text += btn.Text;
                CurrentNum = float.Parse(textBox.Text);
            }
        }

        /// <summary>
        /// Changes the current value to negative
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPosNeg_Click(object sender, EventArgs e)
        {
            CurrentNum *= -1;
            textBox.Text = " " + CurrentNum;

        }

        // -------- Opperands ----------- //

        /// <summary>
        /// Function used to track which opperator button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFunction_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            HoldNum = float.Parse(textBox.Text); //Holds the perviously displayed number
            Opperator = btn.Text; //Store the chosen opperand
            CurrentNum = 0; //reset the current number so the next number isnt appended
        }

        /// <summary>
        /// Calculates the answer and displays it in the TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEqual_Click(object sender, EventArgs e)
        {   
            if (Opperator == "+")
            {
                textBox.Text = "" + (CurrentNum + HoldNum);
            }
            else if (Opperator == "-")
            {
                textBox.Text = "" + (CurrentNum - HoldNum);
            }
            else if (Opperator == "*")
            {
                textBox.Text = "" + (CurrentNum * HoldNum);
            }
            else if (Opperator == "/")
            {
                textBox.Text = "" + (CurrentNum / HoldNum);
            }
            else if (Opperator == "^2")
            {
                textBox.Text = "" + (HoldNum * HoldNum);
            }
            else if (Opperator == "1/x")
            {
                textBox.Text = "" + (1/HoldNum);
            }
            else if (Opperator == "%")
            {
                textBox.Text = "" + (HoldNum % CurrentNum);
            }
            else if (Opperator == "SQRT")
            {
                textBox.Text = "" + (Math.Sqrt(HoldNum));
            }
        }

        

        /// <summary>
        /// Clears only the current number shown in the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCE_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            CurrentNum = 0;
        }

        // -------- CE, C, Backspace Buttons ----------- //

        /// <summary>
        /// Clears the calculator
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
            CurrentNum = 0;
            HoldNum = 0;
            Opperator = "";
        }

        /// <summary>
        /// Deletes the last digit from the current number shown
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBackspace_Click(object sender, EventArgs e)
        {


        }

        // -------- Memory Functions ----------- //

    }
}
