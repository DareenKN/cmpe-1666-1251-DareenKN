namespace Lecture6Exercise1
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
            this.UI_Value_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Result_Tbx = new System.Windows.Forms.TextBox();
            this.UI_CalculateFactorial_Btn = new System.Windows.Forms.Button();
            this.UI_Value_Lbl = new System.Windows.Forms.Label();
            this.UI_Result_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_Value_Tbx
            // 
            this.UI_Value_Tbx.Location = new System.Drawing.Point(212, 51);
            this.UI_Value_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Value_Tbx.Name = "UI_Value_Tbx";
            this.UI_Value_Tbx.Size = new System.Drawing.Size(118, 20);
            this.UI_Value_Tbx.TabIndex = 0;
            // 
            // UI_Result_Tbx
            // 
            this.UI_Result_Tbx.Location = new System.Drawing.Point(225, 167);
            this.UI_Result_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_Result_Tbx.Name = "UI_Result_Tbx";
            this.UI_Result_Tbx.Size = new System.Drawing.Size(113, 20);
            this.UI_Result_Tbx.TabIndex = 1;
            // 
            // UI_CalculateFactorial_Btn
            // 
            this.UI_CalculateFactorial_Btn.Location = new System.Drawing.Point(172, 97);
            this.UI_CalculateFactorial_Btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_CalculateFactorial_Btn.Name = "UI_CalculateFactorial_Btn";
            this.UI_CalculateFactorial_Btn.Size = new System.Drawing.Size(165, 49);
            this.UI_CalculateFactorial_Btn.TabIndex = 2;
            this.UI_CalculateFactorial_Btn.Text = "Calculate Factorial";
            this.UI_CalculateFactorial_Btn.UseVisualStyleBackColor = true;
            this.UI_CalculateFactorial_Btn.Click += new System.EventHandler(this.UI_CalculateFactorial_Btn_Click);
            // 
            // UI_Value_Lbl
            // 
            this.UI_Value_Lbl.AutoSize = true;
            this.UI_Value_Lbl.Location = new System.Drawing.Point(169, 55);
            this.UI_Value_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Value_Lbl.Name = "UI_Value_Lbl";
            this.UI_Value_Lbl.Size = new System.Drawing.Size(44, 15);
            this.UI_Value_Lbl.TabIndex = 3;
            this.UI_Value_Lbl.Text = "Value: ";
            // 
            // UI_Result_Lbl
            // 
            this.UI_Result_Lbl.AutoSize = true;
            this.UI_Result_Lbl.Location = new System.Drawing.Point(169, 171);
            this.UI_Result_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_Result_Lbl.Name = "UI_Result_Lbl";
            this.UI_Result_Lbl.Size = new System.Drawing.Size(48, 15);
            this.UI_Result_Lbl.TabIndex = 4;
            this.UI_Result_Lbl.Text = "Result: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.UI_Result_Lbl);
            this.Controls.Add(this.UI_Value_Lbl);
            this.Controls.Add(this.UI_CalculateFactorial_Btn);
            this.Controls.Add(this.UI_Result_Tbx);
            this.Controls.Add(this.UI_Value_Tbx);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Value_Tbx;
        private System.Windows.Forms.TextBox UI_Result_Tbx;
        private System.Windows.Forms.Button UI_CalculateFactorial_Btn;
        private System.Windows.Forms.Label UI_Value_Lbl;
        private System.Windows.Forms.Label UI_Result_Lbl;
    }
}

