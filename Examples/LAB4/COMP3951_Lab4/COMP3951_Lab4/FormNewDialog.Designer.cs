
namespace COMP3951_Lab4
{
    partial class FormNewDialog
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
            this.button_new_OK = new System.Windows.Forms.Button();
            this.button_new_cancel = new System.Windows.Forms.Button();
            this.radioButton_small = new System.Windows.Forms.RadioButton();
            this.radioButton_med = new System.Windows.Forms.RadioButton();
            this.radioButton_large = new System.Windows.Forms.RadioButton();
            this.panel_new_main = new System.Windows.Forms.Panel();
            this.panel_new_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_new_OK
            // 
            this.button_new_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button_new_OK.Location = new System.Drawing.Point(330, 108);
            this.button_new_OK.Name = "button_new_OK";
            this.button_new_OK.Size = new System.Drawing.Size(113, 47);
            this.button_new_OK.TabIndex = 0;
            this.button_new_OK.Text = "OK";
            this.button_new_OK.UseVisualStyleBackColor = true;
            // 
            // button_new_cancel
            // 
            this.button_new_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_new_cancel.Location = new System.Drawing.Point(330, 205);
            this.button_new_cancel.Name = "button_new_cancel";
            this.button_new_cancel.Size = new System.Drawing.Size(113, 48);
            this.button_new_cancel.TabIndex = 1;
            this.button_new_cancel.Text = "Cancel";
            this.button_new_cancel.UseVisualStyleBackColor = true;
            // 
            // radioButton_small
            // 
            this.radioButton_small.AutoSize = true;
            this.radioButton_small.Location = new System.Drawing.Point(94, 95);
            this.radioButton_small.Name = "radioButton_small";
            this.radioButton_small.Size = new System.Drawing.Size(91, 21);
            this.radioButton_small.TabIndex = 2;
            this.radioButton_small.TabStop = true;
            this.radioButton_small.Text = "640 x 480";
            this.radioButton_small.UseVisualStyleBackColor = true;
            // 
            // radioButton_med
            // 
            this.radioButton_med.AutoSize = true;
            this.radioButton_med.Location = new System.Drawing.Point(94, 170);
            this.radioButton_med.Name = "radioButton_med";
            this.radioButton_med.Size = new System.Drawing.Size(91, 21);
            this.radioButton_med.TabIndex = 3;
            this.radioButton_med.TabStop = true;
            this.radioButton_med.Text = "800 x 600";
            this.radioButton_med.UseVisualStyleBackColor = true;
            // 
            // radioButton_large
            // 
            this.radioButton_large.AutoSize = true;
            this.radioButton_large.Location = new System.Drawing.Point(94, 251);
            this.radioButton_large.Name = "radioButton_large";
            this.radioButton_large.Size = new System.Drawing.Size(99, 21);
            this.radioButton_large.TabIndex = 4;
            this.radioButton_large.TabStop = true;
            this.radioButton_large.Text = "1024 x 768";
            this.radioButton_large.UseVisualStyleBackColor = true;
            // 
            // panel_new_main
            // 
            this.panel_new_main.Controls.Add(this.radioButton_small);
            this.panel_new_main.Controls.Add(this.button_new_cancel);
            this.panel_new_main.Controls.Add(this.radioButton_large);
            this.panel_new_main.Controls.Add(this.button_new_OK);
            this.panel_new_main.Controls.Add(this.radioButton_med);
            this.panel_new_main.Location = new System.Drawing.Point(83, 102);
            this.panel_new_main.Name = "panel_new_main";
            this.panel_new_main.Size = new System.Drawing.Size(531, 361);
            this.panel_new_main.TabIndex = 5;
            // 
            // FormNewDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 509);
            this.Controls.Add(this.panel_new_main);
            this.Name = "FormNewDialog";
            this.Text = "Form2";
            this.panel_new_main.ResumeLayout(false);
            this.panel_new_main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_new_OK;
        private System.Windows.Forms.Button button_new_cancel;
        private System.Windows.Forms.RadioButton radioButton_small;
        private System.Windows.Forms.RadioButton radioButton_med;
        private System.Windows.Forms.RadioButton radioButton_large;
        private System.Windows.Forms.Panel panel_new_main;
    }
}