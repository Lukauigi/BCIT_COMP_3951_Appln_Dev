using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Lab 2 Calculator Submission
/// Include here the authors: Jasper Zhou
/// Include here date/revisions: 2022-01-25
/// Source:
/// </summary>
namespace lab_2_calculator
{

    /// <summary>
    /// Windows Forms Calculator Application
    /// Basic calculator with functions
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>Boolean checks whether memory value exists.</summary>
        bool mem_exists = false;
        /// <summary>Currently stored memory value.</summary>
        Double mem_val = 0;
        /// <summary>stored value for the first operand.</summary>
        Double first_val = 0;
        /// <summary>operation stored as a string.</summary>
        String operation = "";
        /// <summary>boolean checks whether operation is already active.</summary>
        bool operation_on = false;
        /// <summary>boolean checks whether calculator is on.</summary>
        bool calc_on = false;
 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Function resets calculator stored values to default.
        /// </summary>
        public void clear_calcs() {
            mem_val = 0;
            answer.Text = "0";
            first_val = 0;
            operation = "";
            mem_exists = false;
        }

        /// <summary>
        /// Function performs a calculator operation with two operands.
        /// <typeparam>first: first operand value.</typeparam>
        /// <typeparam>operate: operator performed.</typeparam>
        /// <typeparam>second: second operant value.</typeparam>
        /// <return>double result value. 0 by deafult.</return>
        /// </summary>
        public double calculate (double first, string operate, double second) {
            switch (operate)
            {
                case "+":
                    return (first + second);
                case "-":
                    return (first - second);
                case "x":
                    return(first * second);
                case "÷":
                    return (first / second);
            }
            return 0;
        }

        /// <summary> 
        /// Click event digit button  
        /// Event when a digit 0 - 9 or the decimal point are clicked 
        /// Use the sender to find what button was selected 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void buttonDigit_Click(object sender, EventArgs e) {
            if ((answer.Text == "0") || (answer.Text == "x") || (answer.Text == "+") || (answer.Text == "-") || (answer.Text == "÷"))
            {
                answer.Clear();
            }

            Button button = (Button)sender;

            if (button.Text == ".") {
                if (!answer.Text.Contains(".")) {
                    answer.Text += button.Text;
                }
            } 
            else { 
                answer.Text += button.Text;
            }
        }

        /// <summary> 
        /// Click on button  
        /// Event when the on button is clicked
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void on_button_Click(object sender, EventArgs e)
        {
            if (calc_on)
            {
                num_pad.Enabled = false;
                oper_pad.Enabled = false;
                calc_on = false;
                robot_picture.Visible = false;
                mem_pad.Enabled=false;
                clear_calcs();
            }
            else {
                num_pad.Enabled = true;
                calc_on = true;
                robot_picture.Visible = true;
                oper_pad.Enabled = true;
                mem_pad.Enabled = true;
            }
        }

        /// <summary> 
        /// Click event operator button  
        /// Event when an operation button is clicked
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void operate_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "=") 
            {
                if (answer.Text != "+" && answer.Text != "-" && answer.Text != "x" && answer.Text != "÷") {
                    Double second_val = Double.Parse(answer.Text);
                    if (operation_on)
                    {
                        answer.Text = calculate(first_val, operation, second_val).ToString();
                        operation = "";
                        operation_on = false;
                    }
                }   
            }
            else if (button.Text == "1/x")
            {
                answer.Text = (1 / Double.Parse(answer.Text)).ToString();
            }
            else if (button.Text == "x^2")
            {
                answer.Text = (Double.Parse(answer.Text) * Double.Parse(answer.Text)).ToString();
            }
            else if (button.Text == "SQRT")
            {
                answer.Text = (Math.Sqrt(Double.Parse(answer.Text))).ToString();
            }
            else if (button.Text == "%")
            {
                answer.Text = (Double.Parse(answer.Text) * 0.01).ToString();
            }
            else if (operation_on)
            {
                if (!(answer.Text == "+") && !(answer.Text == "-") && !(answer.Text == "x") && !(answer.Text == "÷"))
                {
                    try
                    {
                        first_val = calculate(first_val, operation, Double.Parse(answer.Text));
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("Division by zero error...");
                    }
                    
                }
                operation = button.Text;
                answer.Text = button.Text;
            }
            else {
                operation = button.Text;
                first_val = Double.Parse(answer.Text);
                operation_on = true;
                answer.Text = button.Text;
            }
        }

        /// <summary> 
        /// Click event clear button  
        /// Event when clear entry or all clear button is clicked
        /// Use the sender to find what button was selected 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void clear_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (button.Text == "AC")
            {
                clear_calcs();
            }
            if (button.Text == "CE") {
                operation_on = false;
                operation = "";
                answer.Text = first_val.ToString();
            }

        }

        /// <summary> 
        /// Click event memory button  
        /// Event when a memory button is clicked, performs memory features
        /// Use the sender to find what button was selected 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void mem_button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "MR") {
                if (mem_exists) {
                    answer.Text = mem_val.ToString();
                }
            }
            else if (button.Text == "M+")
            {
                if (Double.TryParse(answer.Text, out var parsedNum))
                {
                    mem_val += Double.Parse(answer.Text);
                    mem_exists = true;
                }
            }
            else if (button.Text == "MS")
            {
                if (Double.TryParse(answer.Text, out var parsedNum)) {
                    mem_val = Double.Parse(answer.Text);
                    mem_exists = true;
                }
            }
            else {
                mem_exists = false;
            }
        }
    }
}
