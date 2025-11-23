namespace Lecture9Exercise2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UI_Num1_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Num2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_Result_Lbl = new System.Windows.Forms.Label();
            this.UI_Add_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Mult_Radio = new System.Windows.Forms.RadioButton();
            this.UI_Div_Radio = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "num 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "num 2:";
            // 
            // UI_Num1_Tbx
            // 
            this.UI_Num1_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Num1_Tbx.Location = new System.Drawing.Point(201, 89);
            this.UI_Num1_Tbx.Name = "UI_Num1_Tbx";
            this.UI_Num1_Tbx.Size = new System.Drawing.Size(133, 22);
            this.UI_Num1_Tbx.TabIndex = 2;
            this.UI_Num1_Tbx.TextChanged += new System.EventHandler(this.UI_Recalculate);
            // 
            // UI_Num2_Tbx
            // 
            this.UI_Num2_Tbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Num2_Tbx.Location = new System.Drawing.Point(201, 143);
            this.UI_Num2_Tbx.Name = "UI_Num2_Tbx";
            this.UI_Num2_Tbx.Size = new System.Drawing.Size(133, 22);
            this.UI_Num2_Tbx.TabIndex = 3;
            this.UI_Num2_Tbx.TextChanged += new System.EventHandler(this.UI_Recalculate);
            // 
            // UI_Result_Lbl
            // 
            this.UI_Result_Lbl.AutoSize = true;
            this.UI_Result_Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Result_Lbl.Location = new System.Drawing.Point(145, 199);
            this.UI_Result_Lbl.Name = "UI_Result_Lbl";
            this.UI_Result_Lbl.Size = new System.Drawing.Size(59, 16);
            this.UI_Result_Lbl.TabIndex = 4;
            this.UI_Result_Lbl.Text = "Result: ";
            // 
            // UI_Add_Radio
            // 
            this.UI_Add_Radio.AutoSize = true;
            this.UI_Add_Radio.Checked = true;
            this.UI_Add_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Add_Radio.Location = new System.Drawing.Point(599, 84);
            this.UI_Add_Radio.Name = "UI_Add_Radio";
            this.UI_Add_Radio.Size = new System.Drawing.Size(82, 20);
            this.UI_Add_Radio.TabIndex = 5;
            this.UI_Add_Radio.TabStop = true;
            this.UI_Add_Radio.Text = "Addition";
            this.UI_Add_Radio.UseVisualStyleBackColor = true;
            this.UI_Add_Radio.CheckedChanged += new System.EventHandler(this.UI_Recalculate);
            // 
            // UI_Mult_Radio
            // 
            this.UI_Mult_Radio.AutoSize = true;
            this.UI_Mult_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Mult_Radio.Location = new System.Drawing.Point(599, 120);
            this.UI_Mult_Radio.Name = "UI_Mult_Radio";
            this.UI_Mult_Radio.Size = new System.Drawing.Size(116, 20);
            this.UI_Mult_Radio.TabIndex = 6;
            this.UI_Mult_Radio.TabStop = true;
            this.UI_Mult_Radio.Text = "Multiplication";
            this.UI_Mult_Radio.UseVisualStyleBackColor = true;
            this.UI_Mult_Radio.CheckedChanged += new System.EventHandler(this.UI_Recalculate);
            // 
            // UI_Div_Radio
            // 
            this.UI_Div_Radio.AutoSize = true;
            this.UI_Div_Radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_Div_Radio.Location = new System.Drawing.Point(599, 156);
            this.UI_Div_Radio.Name = "UI_Div_Radio";
            this.UI_Div_Radio.Size = new System.Drawing.Size(81, 20);
            this.UI_Div_Radio.TabIndex = 7;
            this.UI_Div_Radio.TabStop = true;
            this.UI_Div_Radio.Text = "Division";
            this.UI_Div_Radio.UseVisualStyleBackColor = true;
            this.UI_Div_Radio.CheckedChanged += new System.EventHandler(this.UI_Recalculate);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_Div_Radio);
            this.Controls.Add(this.UI_Mult_Radio);
            this.Controls.Add(this.UI_Add_Radio);
            this.Controls.Add(this.UI_Result_Lbl);
            this.Controls.Add(this.UI_Num2_Tbx);
            this.Controls.Add(this.UI_Num1_Tbx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UI_Num1_Tbx;
        private System.Windows.Forms.TextBox UI_Num2_Tbx;
        private System.Windows.Forms.Label UI_Result_Lbl;
        private System.Windows.Forms.RadioButton UI_Add_Radio;
        private System.Windows.Forms.RadioButton UI_Mult_Radio;
        private System.Windows.Forms.RadioButton UI_Div_Radio;
    }
}

