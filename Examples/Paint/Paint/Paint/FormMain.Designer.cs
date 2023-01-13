namespace Paint
{
    partial class FormMain
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
            this.colorDialogPen = new System.Windows.Forms.ColorDialog();
            this.menuStripColor = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorPenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripColor
            // 
            this.menuStripColor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripColor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStripColor.Location = new System.Drawing.Point(0, 0);
            this.menuStripColor.Name = "menuStripColor";
            this.menuStripColor.Size = new System.Drawing.Size(988, 28);
            this.menuStripColor.TabIndex = 0;
            this.menuStripColor.Text = "Tools";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorPenToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.toolsToolStripMenuItem.Text = "Color";
            // 
            // colorPenToolStripMenuItem
            // 
            this.colorPenToolStripMenuItem.Name = "colorPenToolStripMenuItem";
            this.colorPenToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.colorPenToolStripMenuItem.Text = "Color Pen";
            this.colorPenToolStripMenuItem.Click += new System.EventHandler(this.colorPenToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 510);
            this.Controls.Add(this.menuStripColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStripColor;
            this.Name = "FormMain";
            this.Text = "Paint App -Mouse Double Click to upload picture";
            this.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FormMain_MouseUp);
            this.menuStripColor.ResumeLayout(false);
            this.menuStripColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialogPen;
        private System.Windows.Forms.MenuStrip menuStripColor;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorPenToolStripMenuItem;
    }
}

