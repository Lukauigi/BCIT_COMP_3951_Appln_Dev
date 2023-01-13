
namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.panelNumbers = new System.Windows.Forms.Panel();
            this.buttonPosNeg = new System.Windows.Forms.Button();
            this.buttonPeriod = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panelMemory = new System.Windows.Forms.Panel();
            this.buttonMemC = new System.Windows.Forms.Button();
            this.buttonMemR = new System.Windows.Forms.Button();
            this.buttonMemS = new System.Windows.Forms.Button();
            this.buttonMemPlus = new System.Windows.Forms.Button();
            this.panelFunctions = new System.Windows.Forms.Panel();
            this.buttonPowerTwo = new System.Windows.Forms.Button();
            this.buttonAddition = new System.Windows.Forms.Button();
            this.buttonSQRT = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonOneOver = new System.Windows.Forms.Button();
            this.panelExtra = new System.Windows.Forms.Panel();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.buttonBackspace = new System.Windows.Forms.Button();
            this.buttonOff = new System.Windows.Forms.Button();
            this.panelNumbers.SuspendLayout();
            this.panelMemory.SuspendLayout();
            this.panelFunctions.SuspendLayout();
            this.panelExtra.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(15, 18);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(488, 31);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panelNumbers
            // 
            this.panelNumbers.Controls.Add(this.buttonPosNeg);
            this.panelNumbers.Controls.Add(this.buttonPeriod);
            this.panelNumbers.Controls.Add(this.button0);
            this.panelNumbers.Controls.Add(this.button9);
            this.panelNumbers.Controls.Add(this.button8);
            this.panelNumbers.Controls.Add(this.button7);
            this.panelNumbers.Controls.Add(this.button6);
            this.panelNumbers.Controls.Add(this.button5);
            this.panelNumbers.Controls.Add(this.button4);
            this.panelNumbers.Controls.Add(this.button3);
            this.panelNumbers.Controls.Add(this.button1);
            this.panelNumbers.Controls.Add(this.button2);
            this.panelNumbers.Location = new System.Drawing.Point(15, 161);
            this.panelNumbers.Name = "panelNumbers";
            this.panelNumbers.Size = new System.Drawing.Size(201, 244);
            this.panelNumbers.TabIndex = 1;
            // 
            // buttonPosNeg
            // 
            this.buttonPosNeg.Enabled = false;
            this.buttonPosNeg.Location = new System.Drawing.Point(130, 177);
            this.buttonPosNeg.Name = "buttonPosNeg";
            this.buttonPosNeg.Size = new System.Drawing.Size(51, 47);
            this.buttonPosNeg.TabIndex = 14;
            this.buttonPosNeg.Text = "+/-";
            this.buttonPosNeg.UseVisualStyleBackColor = true;
            this.buttonPosNeg.Click += new System.EventHandler(this.buttonPosNeg_Click);
            // 
            // buttonPeriod
            // 
            this.buttonPeriod.Enabled = false;
            this.buttonPeriod.Location = new System.Drawing.Point(73, 177);
            this.buttonPeriod.Name = "buttonPeriod";
            this.buttonPeriod.Size = new System.Drawing.Size(51, 47);
            this.buttonPeriod.TabIndex = 13;
            this.buttonPeriod.Text = ".";
            this.buttonPeriod.UseVisualStyleBackColor = true;
            this.buttonPeriod.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button0
            // 
            this.button0.Enabled = false;
            this.button0.Location = new System.Drawing.Point(16, 177);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(51, 47);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(130, 18);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(51, 47);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(73, 18);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(51, 47);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(16, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(51, 47);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(130, 71);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 47);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(73, 71);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(51, 47);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(16, 71);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(51, 47);
            this.button4.TabIndex = 6;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(130, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 47);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(16, 124);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(73, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(51, 47);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // panelMemory
            // 
            this.panelMemory.Controls.Add(this.buttonMemC);
            this.panelMemory.Controls.Add(this.buttonMemR);
            this.panelMemory.Controls.Add(this.buttonMemS);
            this.panelMemory.Controls.Add(this.buttonMemPlus);
            this.panelMemory.Location = new System.Drawing.Point(102, 67);
            this.panelMemory.Name = "panelMemory";
            this.panelMemory.Size = new System.Drawing.Size(401, 70);
            this.panelMemory.TabIndex = 15;
            // 
            // buttonMemC
            // 
            this.buttonMemC.Enabled = false;
            this.buttonMemC.ForeColor = System.Drawing.Color.Red;
            this.buttonMemC.Location = new System.Drawing.Point(17, 11);
            this.buttonMemC.Name = "buttonMemC";
            this.buttonMemC.Size = new System.Drawing.Size(66, 47);
            this.buttonMemC.TabIndex = 17;
            this.buttonMemC.Text = "MC";
            this.buttonMemC.UseVisualStyleBackColor = true;
            // 
            // buttonMemR
            // 
            this.buttonMemR.Enabled = false;
            this.buttonMemR.ForeColor = System.Drawing.Color.Red;
            this.buttonMemR.Location = new System.Drawing.Point(120, 10);
            this.buttonMemR.Name = "buttonMemR";
            this.buttonMemR.Size = new System.Drawing.Size(63, 47);
            this.buttonMemR.TabIndex = 16;
            this.buttonMemR.Text = "MR";
            this.buttonMemR.UseVisualStyleBackColor = true;
            // 
            // buttonMemS
            // 
            this.buttonMemS.Enabled = false;
            this.buttonMemS.ForeColor = System.Drawing.Color.Red;
            this.buttonMemS.Location = new System.Drawing.Point(215, 11);
            this.buttonMemS.Name = "buttonMemS";
            this.buttonMemS.Size = new System.Drawing.Size(63, 47);
            this.buttonMemS.TabIndex = 15;
            this.buttonMemS.Text = "MS";
            this.buttonMemS.UseVisualStyleBackColor = true;
            // 
            // buttonMemPlus
            // 
            this.buttonMemPlus.Enabled = false;
            this.buttonMemPlus.ForeColor = System.Drawing.Color.Red;
            this.buttonMemPlus.Location = new System.Drawing.Point(313, 11);
            this.buttonMemPlus.Name = "buttonMemPlus";
            this.buttonMemPlus.Size = new System.Drawing.Size(66, 47);
            this.buttonMemPlus.TabIndex = 14;
            this.buttonMemPlus.Text = "M+";
            this.buttonMemPlus.UseVisualStyleBackColor = true;
            // 
            // panelFunctions
            // 
            this.panelFunctions.Controls.Add(this.buttonPowerTwo);
            this.panelFunctions.Controls.Add(this.buttonAddition);
            this.panelFunctions.Controls.Add(this.buttonSQRT);
            this.panelFunctions.Controls.Add(this.buttonDivide);
            this.panelFunctions.Controls.Add(this.buttonPercent);
            this.panelFunctions.Controls.Add(this.buttonMultiply);
            this.panelFunctions.Controls.Add(this.buttonSubtract);
            this.panelFunctions.Controls.Add(this.buttonOneOver);
            this.panelFunctions.Location = new System.Drawing.Point(244, 161);
            this.panelFunctions.Name = "panelFunctions";
            this.panelFunctions.Size = new System.Drawing.Size(144, 244);
            this.panelFunctions.TabIndex = 15;
            // 
            // buttonPowerTwo
            // 
            this.buttonPowerTwo.Enabled = false;
            this.buttonPowerTwo.Location = new System.Drawing.Point(73, 177);
            this.buttonPowerTwo.Name = "buttonPowerTwo";
            this.buttonPowerTwo.Size = new System.Drawing.Size(51, 47);
            this.buttonPowerTwo.TabIndex = 13;
            this.buttonPowerTwo.Text = "x^2";
            this.buttonPowerTwo.UseVisualStyleBackColor = true;
            this.buttonPowerTwo.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonAddition
            // 
            this.buttonAddition.Enabled = false;
            this.buttonAddition.Location = new System.Drawing.Point(16, 177);
            this.buttonAddition.Name = "buttonAddition";
            this.buttonAddition.Size = new System.Drawing.Size(51, 47);
            this.buttonAddition.TabIndex = 12;
            this.buttonAddition.Text = "+";
            this.buttonAddition.UseVisualStyleBackColor = true;
            this.buttonAddition.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonSQRT
            // 
            this.buttonSQRT.Enabled = false;
            this.buttonSQRT.Location = new System.Drawing.Point(73, 18);
            this.buttonSQRT.Name = "buttonSQRT";
            this.buttonSQRT.Size = new System.Drawing.Size(51, 47);
            this.buttonSQRT.TabIndex = 10;
            this.buttonSQRT.Text = "sqrt";
            this.buttonSQRT.UseVisualStyleBackColor = true;
            this.buttonSQRT.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Enabled = false;
            this.buttonDivide.Location = new System.Drawing.Point(16, 18);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(51, 47);
            this.buttonDivide.TabIndex = 9;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.Enabled = false;
            this.buttonPercent.Location = new System.Drawing.Point(73, 71);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(51, 47);
            this.buttonPercent.TabIndex = 7;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = true;
            this.buttonPercent.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Enabled = false;
            this.buttonMultiply.Location = new System.Drawing.Point(16, 71);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(51, 47);
            this.buttonMultiply.TabIndex = 6;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.Enabled = false;
            this.buttonSubtract.Location = new System.Drawing.Point(16, 124);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(51, 47);
            this.buttonSubtract.TabIndex = 4;
            this.buttonSubtract.Text = "-";
            this.buttonSubtract.UseVisualStyleBackColor = true;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // buttonOneOver
            // 
            this.buttonOneOver.Enabled = false;
            this.buttonOneOver.Location = new System.Drawing.Point(73, 124);
            this.buttonOneOver.Name = "buttonOneOver";
            this.buttonOneOver.Size = new System.Drawing.Size(51, 47);
            this.buttonOneOver.TabIndex = 3;
            this.buttonOneOver.Text = "1/x";
            this.buttonOneOver.UseVisualStyleBackColor = true;
            this.buttonOneOver.Click += new System.EventHandler(this.buttonFunction_Click);
            // 
            // panelExtra
            // 
            this.panelExtra.Controls.Add(this.buttonEqual);
            this.panelExtra.Controls.Add(this.buttonCE);
            this.panelExtra.Controls.Add(this.buttonC);
            this.panelExtra.Controls.Add(this.buttonBackspace);
            this.panelExtra.Location = new System.Drawing.Point(415, 161);
            this.panelExtra.Name = "panelExtra";
            this.panelExtra.Size = new System.Drawing.Size(88, 244);
            this.panelExtra.TabIndex = 16;
            // 
            // buttonEqual
            // 
            this.buttonEqual.Enabled = false;
            this.buttonEqual.Location = new System.Drawing.Point(16, 177);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(51, 47);
            this.buttonEqual.TabIndex = 12;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = true;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.Enabled = false;
            this.buttonCE.ForeColor = System.Drawing.Color.Red;
            this.buttonCE.Location = new System.Drawing.Point(16, 18);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(51, 47);
            this.buttonCE.TabIndex = 9;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonC
            // 
            this.buttonC.Enabled = false;
            this.buttonC.ForeColor = System.Drawing.Color.Red;
            this.buttonC.Location = new System.Drawing.Point(16, 71);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(51, 47);
            this.buttonC.TabIndex = 6;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // buttonBackspace
            // 
            this.buttonBackspace.Enabled = false;
            this.buttonBackspace.ForeColor = System.Drawing.Color.Red;
            this.buttonBackspace.Location = new System.Drawing.Point(16, 124);
            this.buttonBackspace.Name = "buttonBackspace";
            this.buttonBackspace.Size = new System.Drawing.Size(51, 47);
            this.buttonBackspace.TabIndex = 4;
            this.buttonBackspace.Text = "<-";
            this.buttonBackspace.UseVisualStyleBackColor = true;
            // 
            // buttonOff
            // 
            this.buttonOff.Location = new System.Drawing.Point(30, 78);
            this.buttonOff.Name = "buttonOff";
            this.buttonOff.Size = new System.Drawing.Size(51, 47);
            this.buttonOff.TabIndex = 13;
            this.buttonOff.Text = "On";
            this.buttonOff.UseVisualStyleBackColor = true;
            this.buttonOff.Click += new System.EventHandler(this.ButtonOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 711);
            this.Controls.Add(this.panelExtra);
            this.Controls.Add(this.panelFunctions);
            this.Controls.Add(this.panelMemory);
            this.Controls.Add(this.buttonOff);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panelNumbers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Math Calculator";
            this.panelNumbers.ResumeLayout(false);
            this.panelMemory.ResumeLayout(false);
            this.panelFunctions.ResumeLayout(false);
            this.panelExtra.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelNumbers;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonPosNeg;
        private System.Windows.Forms.Button buttonPeriod;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonOff;
        private System.Windows.Forms.Button buttonMemPlus;
        private System.Windows.Forms.Panel panelMemory;
        private System.Windows.Forms.Button buttonMemS;
        private System.Windows.Forms.Button buttonMemC;
        private System.Windows.Forms.Button buttonMemR;
        private System.Windows.Forms.Panel panelFunctions;
        private System.Windows.Forms.Button buttonPowerTwo;
        private System.Windows.Forms.Button buttonAddition;
        private System.Windows.Forms.Button buttonSQRT;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Button buttonPercent;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonOneOver;
        private System.Windows.Forms.Panel panelExtra;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button buttonCE;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button buttonBackspace;


    }
}

