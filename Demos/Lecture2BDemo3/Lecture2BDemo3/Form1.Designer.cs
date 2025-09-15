namespace Lecture2BDemo3
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
            this.UI_Value1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Value2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Sum_Tbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UI_CalculateSum_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UI_Value1_Tbx
            // 
            this.UI_Value1_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Value1_Tbx.Location = new System.Drawing.Point(224, 54);
            this.UI_Value1_Tbx.Name = "UI_Value1_Tbx";
            this.UI_Value1_Tbx.Size = new System.Drawing.Size(246, 22);
            this.UI_Value1_Tbx.TabIndex = 0;
            // 
            // UI_Value2_Tbx
            // 
            this.UI_Value2_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Value2_Tbx.Location = new System.Drawing.Point(224, 108);
            this.UI_Value2_Tbx.Name = "UI_Value2_Tbx";
            this.UI_Value2_Tbx.Size = new System.Drawing.Size(246, 22);
            this.UI_Value2_Tbx.TabIndex = 1;
            // 
            // UI_Sum_Tbx
            // 
            this.UI_Sum_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Sum_Tbx.Location = new System.Drawing.Point(224, 231);
            this.UI_Sum_Tbx.Name = "UI_Sum_Tbx";
            this.UI_Sum_Tbx.ReadOnly = true;
            this.UI_Sum_Tbx.Size = new System.Drawing.Size(246, 22);
            this.UI_Sum_Tbx.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Value1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Value2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sum:";
            // 
            // UI_CalculateSum_Btn
            // 
            this.UI_CalculateSum_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_CalculateSum_Btn.Location = new System.Drawing.Point(239, 162);
            this.UI_CalculateSum_Btn.Name = "UI_CalculateSum_Btn";
            this.UI_CalculateSum_Btn.Size = new System.Drawing.Size(212, 37);
            this.UI_CalculateSum_Btn.TabIndex = 6;
            this.UI_CalculateSum_Btn.Text = "Calculate Sum";
            this.UI_CalculateSum_Btn.UseVisualStyleBackColor = true;
            this.UI_CalculateSum_Btn.Click += new System.EventHandler(this.UI_CalculateSum_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_CalculateSum_Btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UI_Sum_Tbx);
            this.Controls.Add(this.UI_Value2_Tbx);
            this.Controls.Add(this.UI_Value1_Tbx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UI_Value1_Tbx;
        private System.Windows.Forms.TextBox UI_Value2_Tbx;
        private System.Windows.Forms.TextBox UI_Sum_Tbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UI_CalculateSum_Btn;
    }
}

