namespace lab_2_calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.num_pad = new System.Windows.Forms.GroupBox();
            this.robot_picture = new System.Windows.Forms.PictureBox();
            this.point_button = new System.Windows.Forms.Button();
            this.root_button = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.fract_button = new System.Windows.Forms.Button();
            this.oper_pad = new System.Windows.Forms.GroupBox();
            this.sqr_button = new System.Windows.Forms.Button();
            this.percent_button = new System.Windows.Forms.Button();
            this.eql_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.divide_button = new System.Windows.Forms.Button();
            this.subtract_button = new System.Windows.Forms.Button();
            this.multi_button = new System.Windows.Forms.Button();
            this.del_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.answer = new System.Windows.Forms.TextBox();
            this.on_button = new System.Windows.Forms.Button();
            this.mem_pad = new System.Windows.Forms.GroupBox();
            this.mem_recall = new System.Windows.Forms.Button();
            this.mem_store = new System.Windows.Forms.Button();
            this.mem_clear = new System.Windows.Forms.Button();
            this.mem_plus = new System.Windows.Forms.Button();
            this.num_pad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.robot_picture)).BeginInit();
            this.oper_pad.SuspendLayout();
            this.mem_pad.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_pad
            // 
            this.num_pad.Controls.Add(this.robot_picture);
            this.num_pad.Controls.Add(this.point_button);
            this.num_pad.Controls.Add(this.root_button);
            this.num_pad.Controls.Add(this.button_0);
            this.num_pad.Controls.Add(this.button_3);
            this.num_pad.Controls.Add(this.button_2);
            this.num_pad.Controls.Add(this.button_1);
            this.num_pad.Controls.Add(this.button_6);
            this.num_pad.Controls.Add(this.button_5);
            this.num_pad.Controls.Add(this.button_4);
            this.num_pad.Controls.Add(this.button_9);
            this.num_pad.Controls.Add(this.button_8);
            this.num_pad.Controls.Add(this.button_7);
            this.num_pad.Enabled = false;
            this.num_pad.Location = new System.Drawing.Point(12, 120);
            this.num_pad.Name = "num_pad";
            this.num_pad.Size = new System.Drawing.Size(203, 295);
            this.num_pad.TabIndex = 0;
            this.num_pad.TabStop = false;
            // 
            // robot_picture
            // 
            this.robot_picture.Image = ((System.Drawing.Image)(resources.GetObject("robot_picture.Image")));
            this.robot_picture.Location = new System.Drawing.Point(6, 191);
            this.robot_picture.Name = "robot_picture";
            this.robot_picture.Size = new System.Drawing.Size(125, 98);
            this.robot_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.robot_picture.TabIndex = 5;
            this.robot_picture.TabStop = false;
            this.robot_picture.Visible = false;
            // 
            // point_button
            // 
            this.point_button.Location = new System.Drawing.Point(137, 148);
            this.point_button.Name = "point_button";
            this.point_button.Size = new System.Drawing.Size(60, 37);
            this.point_button.TabIndex = 19;
            this.point_button.Text = ".";
            this.point_button.UseVisualStyleBackColor = true;
            this.point_button.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // root_button
            // 
            this.root_button.Location = new System.Drawing.Point(137, 191);
            this.root_button.Name = "root_button";
            this.root_button.Size = new System.Drawing.Size(60, 37);
            this.root_button.TabIndex = 17;
            this.root_button.Text = "SQRT";
            this.root_button.UseVisualStyleBackColor = true;
            this.root_button.Click += new System.EventHandler(this.operate_click);
            // 
            // button_0
            // 
            this.button_0.Location = new System.Drawing.Point(71, 148);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(60, 37);
            this.button_0.TabIndex = 16;
            this.button_0.Text = "0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_3
            // 
            this.button_3.Location = new System.Drawing.Point(137, 105);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(60, 37);
            this.button_3.TabIndex = 15;
            this.button_3.Text = "3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_2
            // 
            this.button_2.Location = new System.Drawing.Point(71, 105);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(60, 37);
            this.button_2.TabIndex = 14;
            this.button_2.Text = "2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_1
            // 
            this.button_1.Location = new System.Drawing.Point(6, 105);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(60, 37);
            this.button_1.TabIndex = 13;
            this.button_1.Text = "1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_6
            // 
            this.button_6.Location = new System.Drawing.Point(137, 62);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(60, 37);
            this.button_6.TabIndex = 12;
            this.button_6.Text = "6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_5
            // 
            this.button_5.Location = new System.Drawing.Point(72, 62);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(60, 37);
            this.button_5.TabIndex = 11;
            this.button_5.Text = "5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_4
            // 
            this.button_4.Location = new System.Drawing.Point(6, 62);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(60, 37);
            this.button_4.TabIndex = 10;
            this.button_4.Text = "4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_9
            // 
            this.button_9.Location = new System.Drawing.Point(137, 19);
            this.button_9.Name = "button_9";
            this.button_9.Size = new System.Drawing.Size(60, 37);
            this.button_9.TabIndex = 9;
            this.button_9.Text = "9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_8
            // 
            this.button_8.Location = new System.Drawing.Point(71, 19);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(60, 37);
            this.button_8.TabIndex = 8;
            this.button_8.Text = "8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // button_7
            // 
            this.button_7.Location = new System.Drawing.Point(6, 19);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(60, 37);
            this.button_7.TabIndex = 7;
            this.button_7.Text = "7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.buttonDigit_Click);
            // 
            // fract_button
            // 
            this.fract_button.Location = new System.Drawing.Point(69, 191);
            this.fract_button.Name = "fract_button";
            this.fract_button.Size = new System.Drawing.Size(60, 37);
            this.fract_button.TabIndex = 18;
            this.fract_button.Text = "1/x";
            this.fract_button.UseVisualStyleBackColor = true;
            this.fract_button.Click += new System.EventHandler(this.operate_click);
            // 
            // oper_pad
            // 
            this.oper_pad.Controls.Add(this.sqr_button);
            this.oper_pad.Controls.Add(this.fract_button);
            this.oper_pad.Controls.Add(this.percent_button);
            this.oper_pad.Controls.Add(this.eql_button);
            this.oper_pad.Controls.Add(this.add_button);
            this.oper_pad.Controls.Add(this.divide_button);
            this.oper_pad.Controls.Add(this.subtract_button);
            this.oper_pad.Controls.Add(this.multi_button);
            this.oper_pad.Controls.Add(this.del_button);
            this.oper_pad.Controls.Add(this.clear_button);
            this.oper_pad.Enabled = false;
            this.oper_pad.Location = new System.Drawing.Point(221, 120);
            this.oper_pad.Name = "oper_pad";
            this.oper_pad.Size = new System.Drawing.Size(135, 295);
            this.oper_pad.TabIndex = 1;
            this.oper_pad.TabStop = false;
            // 
            // sqr_button
            // 
            this.sqr_button.Location = new System.Drawing.Point(6, 191);
            this.sqr_button.Name = "sqr_button";
            this.sqr_button.Size = new System.Drawing.Size(60, 37);
            this.sqr_button.TabIndex = 19;
            this.sqr_button.Text = "x^2";
            this.sqr_button.UseVisualStyleBackColor = true;
            this.sqr_button.Click += new System.EventHandler(this.operate_click);
            // 
            // percent_button
            // 
            this.percent_button.Location = new System.Drawing.Point(6, 148);
            this.percent_button.Name = "percent_button";
            this.percent_button.Size = new System.Drawing.Size(60, 37);
            this.percent_button.TabIndex = 17;
            this.percent_button.Text = "%";
            this.percent_button.UseVisualStyleBackColor = true;
            this.percent_button.Click += new System.EventHandler(this.operate_click);
            // 
            // eql_button
            // 
            this.eql_button.Location = new System.Drawing.Point(69, 148);
            this.eql_button.Name = "eql_button";
            this.eql_button.Size = new System.Drawing.Size(60, 37);
            this.eql_button.TabIndex = 11;
            this.eql_button.Text = "=";
            this.eql_button.UseVisualStyleBackColor = true;
            this.eql_button.Click += new System.EventHandler(this.operate_click);
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(6, 105);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(60, 37);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "+";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.operate_click);
            // 
            // divide_button
            // 
            this.divide_button.Location = new System.Drawing.Point(69, 62);
            this.divide_button.Name = "divide_button";
            this.divide_button.Size = new System.Drawing.Size(60, 37);
            this.divide_button.TabIndex = 9;
            this.divide_button.Text = "÷";
            this.divide_button.UseVisualStyleBackColor = true;
            this.divide_button.Click += new System.EventHandler(this.operate_click);
            // 
            // subtract_button
            // 
            this.subtract_button.Location = new System.Drawing.Point(69, 105);
            this.subtract_button.Name = "subtract_button";
            this.subtract_button.Size = new System.Drawing.Size(60, 37);
            this.subtract_button.TabIndex = 8;
            this.subtract_button.Text = "-";
            this.subtract_button.UseVisualStyleBackColor = true;
            this.subtract_button.Click += new System.EventHandler(this.operate_click);
            // 
            // multi_button
            // 
            this.multi_button.Location = new System.Drawing.Point(6, 62);
            this.multi_button.Name = "multi_button";
            this.multi_button.Size = new System.Drawing.Size(60, 37);
            this.multi_button.TabIndex = 7;
            this.multi_button.Text = "x";
            this.multi_button.UseVisualStyleBackColor = true;
            this.multi_button.Click += new System.EventHandler(this.operate_click);
            // 
            // del_button
            // 
            this.del_button.Location = new System.Drawing.Point(6, 19);
            this.del_button.Name = "del_button";
            this.del_button.Size = new System.Drawing.Size(60, 37);
            this.del_button.TabIndex = 6;
            this.del_button.Text = "CE";
            this.del_button.UseVisualStyleBackColor = true;
            this.del_button.Click += new System.EventHandler(this.clear_click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(69, 19);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(60, 37);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "AC";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_click);
            // 
            // answer
            // 
            this.answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer.Location = new System.Drawing.Point(12, 26);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(344, 26);
            this.answer.TabIndex = 3;
            this.answer.Text = "0";
            this.answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // on_button
            // 
            this.on_button.Location = new System.Drawing.Point(296, 71);
            this.on_button.Name = "on_button";
            this.on_button.Size = new System.Drawing.Size(60, 37);
            this.on_button.TabIndex = 4;
            this.on_button.Text = "ON/OFF";
            this.on_button.UseVisualStyleBackColor = true;
            this.on_button.Click += new System.EventHandler(this.on_button_Click);
            // 
            // mem_pad
            // 
            this.mem_pad.Controls.Add(this.mem_plus);
            this.mem_pad.Controls.Add(this.mem_clear);
            this.mem_pad.Controls.Add(this.mem_store);
            this.mem_pad.Controls.Add(this.mem_recall);
            this.mem_pad.Enabled = false;
            this.mem_pad.Location = new System.Drawing.Point(12, 59);
            this.mem_pad.Name = "mem_pad";
            this.mem_pad.Size = new System.Drawing.Size(275, 55);
            this.mem_pad.TabIndex = 5;
            this.mem_pad.TabStop = false;
            // 
            // mem_recall
            // 
            this.mem_recall.Location = new System.Drawing.Point(143, 12);
            this.mem_recall.Name = "mem_recall";
            this.mem_recall.Size = new System.Drawing.Size(60, 37);
            this.mem_recall.TabIndex = 9;
            this.mem_recall.Text = "MR";
            this.mem_recall.UseVisualStyleBackColor = true;
            this.mem_recall.Click += new System.EventHandler(this.mem_button_click);
            // 
            // mem_store
            // 
            this.mem_store.Location = new System.Drawing.Point(72, 12);
            this.mem_store.Name = "mem_store";
            this.mem_store.Size = new System.Drawing.Size(60, 37);
            this.mem_store.TabIndex = 10;
            this.mem_store.Text = "MS";
            this.mem_store.UseVisualStyleBackColor = true;
            this.mem_store.Click += new System.EventHandler(this.mem_button_click);
            // 
            // mem_clear
            // 
            this.mem_clear.Location = new System.Drawing.Point(6, 12);
            this.mem_clear.Name = "mem_clear";
            this.mem_clear.Size = new System.Drawing.Size(60, 37);
            this.mem_clear.TabIndex = 11;
            this.mem_clear.Text = "MC";
            this.mem_clear.UseVisualStyleBackColor = true;
            this.mem_clear.Click += new System.EventHandler(this.mem_button_click);
            // 
            // mem_plus
            // 
            this.mem_plus.Location = new System.Drawing.Point(209, 12);
            this.mem_plus.Name = "mem_plus";
            this.mem_plus.Size = new System.Drawing.Size(60, 37);
            this.mem_plus.TabIndex = 12;
            this.mem_plus.Text = "M+";
            this.mem_plus.UseVisualStyleBackColor = true;
            this.mem_plus.Click += new System.EventHandler(this.mem_button_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 446);
            this.Controls.Add(this.mem_pad);
            this.Controls.Add(this.on_button);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.oper_pad);
            this.Controls.Add(this.num_pad);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.num_pad.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.robot_picture)).EndInit();
            this.oper_pad.ResumeLayout(false);
            this.mem_pad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox num_pad;
        private System.Windows.Forms.GroupBox oper_pad;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Button on_button;
        private System.Windows.Forms.Button eql_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button divide_button;
        private System.Windows.Forms.Button subtract_button;
        private System.Windows.Forms.Button multi_button;
        private System.Windows.Forms.Button del_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button fract_button;
        private System.Windows.Forms.Button root_button;
        private System.Windows.Forms.Button sqr_button;
        private System.Windows.Forms.Button percent_button;
        private System.Windows.Forms.PictureBox robot_picture;
        private System.Windows.Forms.Button point_button;
        private System.Windows.Forms.GroupBox mem_pad;
        private System.Windows.Forms.Button mem_clear;
        private System.Windows.Forms.Button mem_store;
        private System.Windows.Forms.Button mem_recall;
        private System.Windows.Forms.Button mem_plus;
    }
}

