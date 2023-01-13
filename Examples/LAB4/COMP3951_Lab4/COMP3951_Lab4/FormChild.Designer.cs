
namespace COMP3951_Lab4
{
    partial class FormChild
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.picture_url = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture_url)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(906, 629);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // picture_url
            // 
            this.picture_url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_url.Location = new System.Drawing.Point(0, 0);
            this.picture_url.Name = "picture_url";
            this.picture_url.Size = new System.Drawing.Size(906, 629);
            this.picture_url.TabIndex = 6;
            this.picture_url.TabStop = false;
            // 
            // FormChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 629);
            this.Controls.Add(this.picture_url);
            this.Controls.Add(this.richTextBox1);
            this.Name = "FormChild";
            this.Text = "Form2";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FormChild_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.picture_url)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox picture_url;
    }
}