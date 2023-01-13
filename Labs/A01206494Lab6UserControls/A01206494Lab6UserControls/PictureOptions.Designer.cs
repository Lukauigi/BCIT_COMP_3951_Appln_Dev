
namespace A01206494Lab6UserControls
{
    partial class PictureOptions
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureOptions));
            this.picture = new System.Windows.Forms.PictureBox();
            this.horizontalSlider = new System.Windows.Forms.TrackBar();
            this.horizontalLabel = new System.Windows.Forms.Label();
            this.verticalLabel = new System.Windows.Forms.Label();
            this.verticalSlider = new System.Windows.Forms.TrackBar();
            this.info = new System.Windows.Forms.Label();
            this.resetButton = new A01206494Lab6UserControls.LukaszButton();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.Image = ((System.Drawing.Image)(resources.GetObject("picture.Image")));
            this.picture.Location = new System.Drawing.Point(25, 25);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(234, 240);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            this.picture.Tag = "picture";
            this.picture.Click += new System.EventHandler(this.Invert);
            // 
            // horizontalSlider
            // 
            this.horizontalSlider.Location = new System.Drawing.Point(17, 488);
            this.horizontalSlider.Maximum = 380;
            this.horizontalSlider.Name = "horizontalSlider";
            this.horizontalSlider.Size = new System.Drawing.Size(248, 45);
            this.horizontalSlider.TabIndex = 4;
            this.horizontalSlider.TickFrequency = 10;
            this.horizontalSlider.Scroll += new System.EventHandler(this.MoveImageHorizontally);
            // 
            // horizontalLabel
            // 
            this.horizontalLabel.AutoSize = true;
            this.horizontalLabel.Location = new System.Drawing.Point(14, 472);
            this.horizontalLabel.Name = "horizontalLabel";
            this.horizontalLabel.Size = new System.Drawing.Size(91, 13);
            this.horizontalLabel.TabIndex = 5;
            this.horizontalLabel.Text = "Move Horizontally";
            // 
            // verticalLabel
            // 
            this.verticalLabel.AutoSize = true;
            this.verticalLabel.Location = new System.Drawing.Point(268, 472);
            this.verticalLabel.Name = "verticalLabel";
            this.verticalLabel.Size = new System.Drawing.Size(79, 13);
            this.verticalLabel.TabIndex = 7;
            this.verticalLabel.Text = "Move Veritcally";
            // 
            // verticalSlider
            // 
            this.verticalSlider.Location = new System.Drawing.Point(271, 488);
            this.verticalSlider.Maximum = 200;
            this.verticalSlider.Name = "verticalSlider";
            this.verticalSlider.Size = new System.Drawing.Size(248, 45);
            this.verticalSlider.TabIndex = 6;
            this.verticalSlider.TickFrequency = 5;
            this.verticalSlider.Scroll += new System.EventHandler(this.MoveImageVetically);
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Location = new System.Drawing.Point(93, 6);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(88, 13);
            this.info.TabIndex = 8;
            this.info.Text = "Click pic to invert";
            // 
            // resetButton
            // 
            this.resetButton.BackgroundColor = System.Drawing.Color.Red;
            this.resetButton.BackgroundTransparencey = 40;
            this.resetButton.ForegroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.resetButton.ForegroundTransparencey = 100;
            this.resetButton.Location = new System.Drawing.Point(543, 491);
            this.resetButton.Name = "resetButton";
            this.resetButton.Pattern = System.Drawing.Drawing2D.HatchStyle.Percent75;
            this.resetButton.Size = new System.Drawing.Size(121, 32);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            // 
            // PictureOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.info);
            this.Controls.Add(this.verticalLabel);
            this.Controls.Add(this.verticalSlider);
            this.Controls.Add(this.horizontalLabel);
            this.Controls.Add(this.horizontalSlider);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.picture);
            this.Name = "PictureOptions";
            this.Size = new System.Drawing.Size(686, 544);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horizontalSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verticalSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private LukaszButton resetButton;
        private System.Windows.Forms.TrackBar horizontalSlider;
        private System.Windows.Forms.Label horizontalLabel;
        private System.Windows.Forms.Label verticalLabel;
        private System.Windows.Forms.TrackBar verticalSlider;
        private System.Windows.Forms.Label info;
    }
}
