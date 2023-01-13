
using A01206494Lab6UserControls;

namespace Lab6LibraryExecutor
{
    partial class Tester
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
            this.eventButton = new A01206494Lab6UserControls.LukaszButton();
            this.userControlRGBSelectorLukaszBednarek1 = new A01206494Lab6UserControls.UserControlRGBSelectorLukaszBednarek();
            this.pictureOptions1 = new A01206494Lab6UserControls.PictureOptions();
            this.SuspendLayout();
            // 
            // eventButton
            // 
            this.eventButton.BackgroundColor = System.Drawing.Color.Yellow;
            this.eventButton.BackgroundTransparencey = 128;
            this.eventButton.ForegroundColor = System.Drawing.Color.Black;
            this.eventButton.ForegroundTransparencey = 255;
            this.eventButton.Location = new System.Drawing.Point(229, 320);
            this.eventButton.Name = "eventButton";
            this.eventButton.Pattern = System.Drawing.Drawing2D.HatchStyle.DashedVertical;
            this.eventButton.Size = new System.Drawing.Size(123, 62);
            this.eventButton.TabIndex = 1;
            this.eventButton.Text = "lukaszButton1";
            this.eventButton.UseVisualStyleBackColor = true;
            // 
            // userControlRGBSelectorLukaszBednarek1
            // 
            this.userControlRGBSelectorLukaszBednarek1.Location = new System.Drawing.Point(12, 12);
            this.userControlRGBSelectorLukaszBednarek1.Name = "userControlRGBSelectorLukaszBednarek1";
            this.userControlRGBSelectorLukaszBednarek1.Size = new System.Drawing.Size(576, 302);
            this.userControlRGBSelectorLukaszBednarek1.TabIndex = 0;
            // 
            // pictureOptions1
            // 
            this.pictureOptions1.Location = new System.Drawing.Point(575, 12);
            this.pictureOptions1.Name = "pictureOptions1";
            this.pictureOptions1.Size = new System.Drawing.Size(686, 544);
            this.pictureOptions1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 574);
            this.Controls.Add(this.pictureOptions1);
            this.Controls.Add(this.eventButton);
            this.Controls.Add(this.userControlRGBSelectorLukaszBednarek1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UserControlRGBSelectorLukaszBednarek userControlRGBSelectorLukaszBednarek1;
        private LukaszButton eventButton;
        private PictureOptions pictureOptions1;
    }
}

