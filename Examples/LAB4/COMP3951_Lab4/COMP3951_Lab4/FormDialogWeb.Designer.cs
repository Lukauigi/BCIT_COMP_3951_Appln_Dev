
namespace COMP3951_Lab4
{
    partial class FormDialogWeb
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
            this.label_form_web = new System.Windows.Forms.Label();
            this.textbox_url = new System.Windows.Forms.TextBox();
            this.button_formweb_OK = new System.Windows.Forms.Button();
            this.button_formweb_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_form_web
            // 
            this.label_form_web.AutoSize = true;
            this.label_form_web.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_form_web.Location = new System.Drawing.Point(36, 104);
            this.label_form_web.Name = "label_form_web";
            this.label_form_web.Size = new System.Drawing.Size(110, 29);
            this.label_form_web.TabIndex = 0;
            this.label_form_web.Text = "Location:";
            // 
            // textbox_url
            // 
            this.textbox_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_url.Location = new System.Drawing.Point(39, 139);
            this.textbox_url.Name = "textbox_url";
            this.textbox_url.Size = new System.Drawing.Size(514, 34);
            this.textbox_url.TabIndex = 1;
            // 
            // button_formweb_OK
            // 
            this.button_formweb_OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_formweb_OK.Location = new System.Drawing.Point(138, 212);
            this.button_formweb_OK.Name = "button_formweb_OK";
            this.button_formweb_OK.Size = new System.Drawing.Size(124, 53);
            this.button_formweb_OK.TabIndex = 2;
            this.button_formweb_OK.Text = "OK";
            this.button_formweb_OK.UseVisualStyleBackColor = true;
            //this.button_formweb_OK.Click += new System.EventHandler(this.button_formweb_OK_Click);
            // 
            // button_formweb_cancel
            // 
            this.button_formweb_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_formweb_cancel.Location = new System.Drawing.Point(309, 212);
            this.button_formweb_cancel.Name = "button_formweb_cancel";
            this.button_formweb_cancel.Size = new System.Drawing.Size(117, 53);
            this.button_formweb_cancel.TabIndex = 3;
            this.button_formweb_cancel.Text = "Cancel";
            this.button_formweb_cancel.UseVisualStyleBackColor = true;
            // 
            // FormDialogWeb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 335);
            this.Controls.Add(this.button_formweb_cancel);
            this.Controls.Add(this.button_formweb_OK);
            this.Controls.Add(this.textbox_url);
            this.Controls.Add(this.label_form_web);
            this.Name = "FormDialogWeb";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_form_web;
        private System.Windows.Forms.TextBox textbox_url;
        private System.Windows.Forms.Button button_formweb_OK;
        private System.Windows.Forms.Button button_formweb_cancel;
    }
}