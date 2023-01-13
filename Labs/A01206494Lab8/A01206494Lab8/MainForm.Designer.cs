
namespace A01206494Lab8
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.customerDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AutoGenerateColumns = false;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.DataSource = this.customerDBDataSetBindingSource;
            this.dataGridCustomers.Location = new System.Drawing.Point(12, 12);
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.Size = new System.Drawing.Size(414, 188);
            this.dataGridCustomers.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 450);
            this.Controls.Add(this.dataGridCustomers);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDBDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.BindingSource customerDBDataSetBindingSource;
    }
}

