namespace Lecture2BDemo9
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
            this.UI_Taxrate_Gbx = new System.Windows.Forms.GroupBox();
            this.UI_5Percent_Radio = new System.Windows.Forms.RadioButton();
            this.UI_7Percent_Radio = new System.Windows.Forms.RadioButton();
            this.UI_10Percent_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Input_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TotalCost_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_Taxrate_Gbx.SuspendLayout();
            this.SuspendLayout();
            // 
            // UI_Taxrate_Gbx
            // 
            this.UI_Taxrate_Gbx.Controls.Add(this.UI_10Percent_Radio);
            this.UI_Taxrate_Gbx.Controls.Add(this.UI_7Percent_Radio);
            this.UI_Taxrate_Gbx.Controls.Add(this.UI_5Percent_Radio);
            this.UI_Taxrate_Gbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Taxrate_Gbx.Location = new System.Drawing.Point(74, 49);
            this.UI_Taxrate_Gbx.Name = "UI_Taxrate_Gbx";
            this.UI_Taxrate_Gbx.Size = new System.Drawing.Size(255, 170);
            this.UI_Taxrate_Gbx.TabIndex = 0;
            this.UI_Taxrate_Gbx.TabStop = false;
            this.UI_Taxrate_Gbx.Text = "TaxRate";
            // 
            // UI_5Percent_Radio
            // 
            this.UI_5Percent_Radio.AutoSize = true;
            this.UI_5Percent_Radio.Checked = true;
            this.UI_5Percent_Radio.Location = new System.Drawing.Point(20, 32);
            this.UI_5Percent_Radio.Name = "UI_5Percent_Radio";
            this.UI_5Percent_Radio.Size = new System.Drawing.Size(46, 20);
            this.UI_5Percent_Radio.TabIndex = 1;
            this.UI_5Percent_Radio.TabStop = true;
            this.UI_5Percent_Radio.Text = "5%";
            this.UI_5Percent_Radio.UseVisualStyleBackColor = true;
            this.UI_5Percent_Radio.CheckedChanged += new System.EventHandler(this.UI_CalculateCost);
            // 
            // UI_7Percent_Radio
            // 
            this.UI_7Percent_Radio.AutoSize = true;
            this.UI_7Percent_Radio.Location = new System.Drawing.Point(20, 74);
            this.UI_7Percent_Radio.Name = "UI_7Percent_Radio";
            this.UI_7Percent_Radio.Size = new System.Drawing.Size(46, 20);
            this.UI_7Percent_Radio.TabIndex = 2;
            this.UI_7Percent_Radio.Text = "7%";
            this.UI_7Percent_Radio.UseVisualStyleBackColor = true;
            this.UI_7Percent_Radio.CheckedChanged += new System.EventHandler(this.UI_CalculateCost);
            // 
            // UI_10Percent_Radio
            // 
            this.UI_10Percent_Radio.AutoSize = true;
            this.UI_10Percent_Radio.Location = new System.Drawing.Point(20, 123);
            this.UI_10Percent_Radio.Name = "UI_10Percent_Radio";
            this.UI_10Percent_Radio.Size = new System.Drawing.Size(54, 20);
            this.UI_10Percent_Radio.TabIndex = 3;
            this.UI_10Percent_Radio.Text = "10%";
            this.UI_10Percent_Radio.UseVisualStyleBackColor = true;
            this.UI_10Percent_Radio.CheckedChanged += new System.EventHandler(this.UI_CalculateCost);
            // 
            // UI_Input_Tbx
            // 
            this.UI_Input_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Input_Tbx.Location = new System.Drawing.Point(515, 100);
            this.UI_Input_Tbx.Name = "UI_Input_Tbx";
            this.UI_Input_Tbx.Size = new System.Drawing.Size(180, 22);
            this.UI_Input_Tbx.TabIndex = 1;
            this.UI_Input_Tbx.TextChanged += new System.EventHandler(this.UI_CalculateCost);
            // 
            // UI_TotalCost_Tbx
            // 
            this.UI_TotalCost_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalCost_Tbx.Location = new System.Drawing.Point(515, 188);
            this.UI_TotalCost_Tbx.Name = "UI_TotalCost_Tbx";
            this.UI_TotalCost_Tbx.ReadOnly = true;
            this.UI_TotalCost_Tbx.Size = new System.Drawing.Size(180, 22);
            this.UI_TotalCost_Tbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Item Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Cost (Including Tax)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_TotalCost_Tbx);
            this.Controls.Add(this.UI_Input_Tbx);
            this.Controls.Add(this.UI_Taxrate_Gbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.UI_Taxrate_Gbx.ResumeLayout(false);
            this.UI_Taxrate_Gbx.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox UI_Taxrate_Gbx;
        private System.Windows.Forms.RadioButton UI_10Percent_Radio;
        private System.Windows.Forms.RadioButton UI_7Percent_Radio;
        private System.Windows.Forms.RadioButton UI_5Percent_Radio;
        private System.Windows.Forms.TextBox UI_Input_Tbx;
        private System.Windows.Forms.TextBox UI_TotalCost_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

