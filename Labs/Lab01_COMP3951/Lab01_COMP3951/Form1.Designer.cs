/// <summary>
/// Form design & properties.
/// Authors: Lukasz Bednarek, Jeremy Schmidt
/// Date: January 2021
/// </summary>
namespace Lab01
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
            this.cookieClicker = new System.Windows.Forms.Button();
            this.cookieCount = new System.Windows.Forms.Label();
            this.appliancesCategory = new System.Windows.Forms.RadioButton();
            this.furnitureCategory = new System.Windows.Forms.RadioButton();
            this.rewardHeader = new System.Windows.Forms.Label();
            this.buyAppliance1 = new System.Windows.Forms.Button();
            this.applianceName1 = new System.Windows.Forms.Label();
            this.appliancePrice1 = new System.Windows.Forms.Label();
            this.warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cookieClicker
            // 
            this.cookieClicker.Image = global::Lab01_COMP3951.Properties.Resources.Cookie_Transparent;
            this.cookieClicker.Location = new System.Drawing.Point(12, 152);
            this.cookieClicker.Name = "cookieClicker";
            this.cookieClicker.Size = new System.Drawing.Size(266, 255);
            this.cookieClicker.TabIndex = 0;
            this.cookieClicker.UseVisualStyleBackColor = true;
            this.cookieClicker.Click += new System.EventHandler(this.CookieClicker_Click);
            // 
            // cookieCount
            // 
            this.cookieCount.AutoSize = true;
            this.cookieCount.Font = new System.Drawing.Font("Arial", 26F);
            this.cookieCount.Location = new System.Drawing.Point(4, 50);
            this.cookieCount.Name = "cookieCount";
            this.cookieCount.Size = new System.Drawing.Size(258, 40);
            this.cookieCount.TabIndex = 1;
            this.cookieCount.Text = "Cookie Bank:  0";
            // 
            // appliancesCategory
            // 
            this.appliancesCategory.AutoSize = true;
            this.appliancesCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.appliancesCategory.Location = new System.Drawing.Point(664, 16);
            this.appliancesCategory.Name = "appliancesCategory";
            this.appliancesCategory.Size = new System.Drawing.Size(104, 22);
            this.appliancesCategory.TabIndex = 3;
            this.appliancesCategory.TabStop = true;
            this.appliancesCategory.Text = "Appliances";
            this.appliancesCategory.UseVisualStyleBackColor = true;
            this.appliancesCategory.CheckedChanged += new System.EventHandler(this.AppliancesCategory_CheckedChanged);
            // 
            // furnitureCategory
            // 
            this.furnitureCategory.AutoSize = true;
            this.furnitureCategory.Font = new System.Drawing.Font("Arial", 12F);
            this.furnitureCategory.Location = new System.Drawing.Point(547, 16);
            this.furnitureCategory.Name = "furnitureCategory";
            this.furnitureCategory.Size = new System.Drawing.Size(87, 22);
            this.furnitureCategory.TabIndex = 4;
            this.furnitureCategory.TabStop = true;
            this.furnitureCategory.Text = "Furniture";
            this.furnitureCategory.UseVisualStyleBackColor = true;
            // 
            // rewardHeader
            // 
            this.rewardHeader.AutoSize = true;
            this.rewardHeader.Font = new System.Drawing.Font("Arial", 14F);
            this.rewardHeader.Location = new System.Drawing.Point(424, 15);
            this.rewardHeader.Name = "rewardHeader";
            this.rewardHeader.Size = new System.Drawing.Size(90, 22);
            this.rewardHeader.TabIndex = 5;
            this.rewardHeader.Text = "Rewards:";
            // 
            // buyAppliance1
            // 
            this.buyAppliance1.Font = new System.Drawing.Font("Arial", 10F);
            this.buyAppliance1.Location = new System.Drawing.Point(428, 102);
            this.buyAppliance1.Name = "buyAppliance1";
            this.buyAppliance1.Size = new System.Drawing.Size(75, 23);
            this.buyAppliance1.TabIndex = 6;
            this.buyAppliance1.Text = "Buy";
            this.buyAppliance1.UseVisualStyleBackColor = true;
            this.buyAppliance1.Visible = false;
            this.buyAppliance1.Click += new System.EventHandler(this.buyAppliance1_Click);
            // 
            // applianceName1
            // 
            this.applianceName1.AutoSize = true;
            this.applianceName1.Font = new System.Drawing.Font("Arial", 10F);
            this.applianceName1.Location = new System.Drawing.Point(567, 105);
            this.applianceName1.Name = "applianceName1";
            this.applianceName1.Size = new System.Drawing.Size(0, 16);
            this.applianceName1.TabIndex = 7;
            this.applianceName1.Visible = false;
            // 
            // appliancePrice1
            // 
            this.appliancePrice1.AutoSize = true;
            this.appliancePrice1.Font = new System.Drawing.Font("Arial", 10F);
            this.appliancePrice1.Location = new System.Drawing.Point(674, 105);
            this.appliancePrice1.Name = "appliancePrice1";
            this.appliancePrice1.Size = new System.Drawing.Size(71, 16);
            this.appliancePrice1.TabIndex = 8;
            this.appliancePrice1.Text = "0 Cookies";
            this.appliancePrice1.Visible = false;
            // 
            // warning
            // 
            this.warning.AutoSize = true;
            this.warning.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warning.Location = new System.Drawing.Point(452, 409);
            this.warning.Name = "warning";
            this.warning.Size = new System.Drawing.Size(273, 18);
            this.warning.TabIndex = 9;
            this.warning.Text = "You need more cookies for that award.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.warning);
            this.Controls.Add(this.appliancePrice1);
            this.Controls.Add(this.applianceName1);
            this.Controls.Add(this.buyAppliance1);
            this.Controls.Add(this.rewardHeader);
            this.Controls.Add(this.furnitureCategory);
            this.Controls.Add(this.appliancesCategory);
            this.Controls.Add(this.cookieCount);
            this.Controls.Add(this.cookieClicker);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cookieClicker;
        private System.Windows.Forms.Label cookieCount;
        private System.Windows.Forms.RadioButton appliancesCategory;
        private System.Windows.Forms.RadioButton furnitureCategory;
        private System.Windows.Forms.Label rewardHeader;
        private System.Windows.Forms.Button buyAppliance1;
        private System.Windows.Forms.Label applianceName1;
        private System.Windows.Forms.Label appliancePrice1;
        private System.Windows.Forms.Label warning;
    }
}

