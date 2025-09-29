namespace EventConsolidationDemo
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
            this.UI_Red_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Green_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Blue_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Color_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_Red_Radio
            // 
            this.UI_Red_Radio.AutoSize = true;
            this.UI_Red_Radio.Checked = true;
            this.UI_Red_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Red_Radio.Location = new System.Drawing.Point(150, 168);
            this.UI_Red_Radio.Name = "UI_Red_Radio";
            this.UI_Red_Radio.Size = new System.Drawing.Size(54, 20);
            this.UI_Red_Radio.TabIndex = 0;
            this.UI_Red_Radio.TabStop = true;
            this.UI_Red_Radio.Text = "Red";
            this.UI_Red_Radio.UseVisualStyleBackColor = true;
            this.UI_Red_Radio.CheckedChanged += new System.EventHandler(this.UI_Red_Radio_CheckedChanged);
            // 
            // UI_Green_Radio
            // 
            this.UI_Green_Radio.AutoSize = true;
            this.UI_Green_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Green_Radio.Location = new System.Drawing.Point(150, 207);
            this.UI_Green_Radio.Name = "UI_Green_Radio";
            this.UI_Green_Radio.Size = new System.Drawing.Size(67, 20);
            this.UI_Green_Radio.TabIndex = 1;
            this.UI_Green_Radio.Text = "Green";
            this.UI_Green_Radio.UseVisualStyleBackColor = true;
            this.UI_Green_Radio.CheckedChanged += new System.EventHandler(this.UI_Green_Radio_CheckedChanged);
            // 
            // UI_Blue_Radio
            // 
            this.UI_Blue_Radio.AutoSize = true;
            this.UI_Blue_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Blue_Radio.Location = new System.Drawing.Point(150, 250);
            this.UI_Blue_Radio.Name = "UI_Blue_Radio";
            this.UI_Blue_Radio.Size = new System.Drawing.Size(56, 20);
            this.UI_Blue_Radio.TabIndex = 2;
            this.UI_Blue_Radio.Text = "Blue";
            this.UI_Blue_Radio.UseVisualStyleBackColor = true;
            this.UI_Blue_Radio.CheckedChanged += new System.EventHandler(this.UI_Blue_Radio_CheckedChanged);
            // 
            // UI_Color_Tbx
            // 
            this.UI_Color_Tbx.Location = new System.Drawing.Point(307, 207);
            this.UI_Color_Tbx.Name = "UI_Color_Tbx";
            this.UI_Color_Tbx.Size = new System.Drawing.Size(395, 20);
            this.UI_Color_Tbx.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Color_Tbx);
            this.Controls.Add(this.UI_Blue_Radio);
            this.Controls.Add(this.UI_Green_Radio);
            this.Controls.Add(this.UI_Red_Radio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton UI_Red_Radio;
        private System.Windows.Forms.RadioButton UI_Green_Radio;
        private System.Windows.Forms.RadioButton UI_Blue_Radio;
        private System.Windows.Forms.TextBox UI_Color_Tbx;
    }
}

